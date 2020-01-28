using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;



namespace poc_restsharp_superdigital.Utils
{
    public class JsonUtils
    {
        /// <summary>
        /// A method for finding and value in Json by it's key
        /// </summary>
        /// <param name="response"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static String GetJsonValue(IRestResponse response, string key)
        {
            string value = "picles";
            var convertedContent = JObject.Parse(response.Content);

            foreach (KeyValuePair<string, JToken> keyValuePair in convertedContent)
            {
                if (key == keyValuePair.Key)
                {
                    value = keyValuePair.Value.ToString();
                }
            }

            return value;
        }
    }
}
