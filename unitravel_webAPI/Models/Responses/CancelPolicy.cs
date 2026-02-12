using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class CancelPolicy
    {
        [JsonProperty("index")]
        public string Index {  get; set; }
        [JsonProperty("fromDate")]
        public string FromDate { get; set; } // using YYYY-MM-DD format
        [JsonProperty("chargeType")]
        public string ChargeType { get; set; }
        [JsonProperty("cancellationCharge")]
        public decimal CancallationCharge { get; set; }

        public CancelPolicy()
        {
            Index = string.Empty;
            FromDate = string.Empty;
            ChargeType = string.Empty;
            CancallationCharge = 0;
        }
    }
}
