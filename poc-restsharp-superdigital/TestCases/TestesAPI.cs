using System;
using NUnit;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;
using poc_restsharp_superdigital.Utils;
using poc_restsharp_superdigital.Models;
using NJsonSchema;

namespace poc_restsharp_superdigital
{

    [TestFixture]
    public class TestesAPI
    {
        IRestResponse response;

        [Test]
        public void testePositivoRetirada()
        {
            var client = new RestClient(RequestConstants.BaseUrl);
            var request = new RestRequest("/restgateway/api/rec/withdraw", Method.POST);

            var WithdrawReq = new
            {
                msgID = 2019103017093211100,
                dt = "",
                dhLocal = "",
                dtTransaction = "",
                seqID = "000000666666",
                contractID = "9999",
                accountID = "000000000001",
                clientPassword = "2E9B6E81EC6349E2",
                withdrawAmount = "00000000100",
                acquirer = "1"
            };


            request.AddJsonBody(WithdrawReq);
            
            response = client.Execute(request);
            Console.WriteLine(response.Content);

            string ourNumber = JsonUtils.GetJsonValue(response, "ourNumber");

            var requestConfirmation = new RestRequest("/restgateway/api/rec/withdraw_confirmation", Method.POST);

            var WithdrawConfirmationReq = new
            {
                msgID = 2019103017094411000,
                dt = "2019-10-30T08:08:08.000-0300",
                dhLocal = "2019-10-30T08:08:08.000-000",
                dtTransaction = "2019-10-30T17:09:44.097-0300",
                seqID = "000000666666",
                contractID = "5123",
                ourNumber = ourNumber,
                withdrawStatus = "00"
            };

            requestConfirmation.AddJsonBody(WithdrawConfirmationReq);

            response = client.Execute(requestConfirmation);
            Console.WriteLine(response.Content);

            string statusCode = JsonUtils.GetJsonValue(response, "status");

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
