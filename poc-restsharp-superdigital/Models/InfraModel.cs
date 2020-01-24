using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace poc_restsharp_superdigital.Models
{
    public class InfraModel
    {
        [JsonProperty(PropertyName = "msgID")]
        public Int64 msgID { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public string dt { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string source { get; set; }

        [JsonProperty(PropertyName = "contractID")]
        public string contractID { get; set; }
    }

    public class InfraSchema
    {
        [JsonRequired]
        public Int64 msgID { get; set; }

        [JsonRequired]
        public DateTime dt { get; set; }

        [JsonRequired]
        public string linkStatus { get; set; }
    }
}
