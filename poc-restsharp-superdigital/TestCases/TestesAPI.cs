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
        public void testePositivoInfraEcho()
        {
            var client = new RestClient(RequestConstants.BaseUrl);
            var request = new RestRequest("/restgateway/api/infra/echo", Method.POST);

            var body = new
            {
                msgID = 2019103017081911000,
                dt = "2019-10-30T14:02:53.000-0300",
                source = "ET",
                contractID = "5123"
            };

            request.AddJsonBody(body);

            try
            {
                response = client.Execute(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível realizar a chamada: " + e.Message);
            }

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            Console.WriteLine(response.Content);
        }

        [Test]
        public async System.Threading.Tasks.Task testeContratoIngraEchoAsync()
        {
            /*
            //var schema = await JsonSchema4.FromTypeAsync<Person>();
            //var schemaData = schema.ToJson();
            //var errors = schema.Validate("{...}");

            foreach (var error in errors)
                Console.WriteLine(error.Path + ": " + error.Kind);

            schema = await JsonSchema4.FromJsonAsync(schemaData);*/
        }
    }
}
