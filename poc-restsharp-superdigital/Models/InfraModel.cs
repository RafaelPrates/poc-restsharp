using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace poc_restsharp_superdigital.Models
{
    public class WithdrawResponseModel
    {
        [JsonProperty(PropertyName = "msgID")]
        public Int64 msgID { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public string dt { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "ourNumber")]
        public string ourNumber { get; set; }

        [JsonProperty(PropertyName = "customerName")]
        public string customerName { get; set; }

        [JsonProperty(PropertyName = "customerID")]
        public string customerID { get; set; }

        [JsonProperty(PropertyName = "withdrawAmount")]
        public string withdrawAmount { get; set; }

        [JsonProperty(PropertyName = "customerMessage")]
        public string customerMessage { get; set; }

        [JsonProperty(PropertyName = "requestFunding")]
        public int requestFunding { get; set; }

        [JsonProperty(PropertyName = "balanceDescription")]
        public string balanceDescription { get; set; }

        [JsonProperty(PropertyName = "availableBalance")]
        public string availableBalance { get; set; }
    }

    public class WithdrawRequest
    {
        public WithdrawRequest(long msgID, string dt, string dhLocal, string dtTransaction, string seqID, string contractID, string accountID, string clientPassword, string withdrawAmount, string acquirer)
        {
            this.msgID = msgID;
            this.dt = dt;
            this.dhLocal = dhLocal;
            this.dtTransaction = dtTransaction;
            this.seqID = seqID;
            this.contractID = contractID;
            this.accountID = accountID;
            this.clientPassword = clientPassword;
            this.withdrawAmount = withdrawAmount;
            this.acquirer = acquirer;
        }

        [JsonProperty(PropertyName = "msgID")]
        public Int64 msgID { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public string dt { get; set; }

        [JsonProperty(PropertyName = "dhLocal")]
        public string dhLocal { get; set; }

        [JsonProperty(PropertyName = "dtTransaction")]
        public string dtTransaction { get; set; }

        [JsonProperty(PropertyName = "seqID")]
        public string seqID { get; set; }

        [JsonProperty(PropertyName = "contractID")]
        public string contractID { get; set; }

        [JsonProperty(PropertyName = "accountID")]
        public string accountID { get; set; }

        [JsonProperty(PropertyName = "clientPassword")]
        public string clientPassword { get; set; }

        [JsonProperty(PropertyName = "withdrawAmount")]
        public string withdrawAmount { get; set; }

        [JsonProperty(PropertyName = "acquirer")]
        public string acquirer { get; set; }
    }
}
