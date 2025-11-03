using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class CancelPolicy
    {
        [JsonProperty("Index")]
        public string Index {  get; set; }
        [JsonProperty("FromDate")]
        public string FromDate { get; set; } // using YYYY-MM-DD format
        [JsonProperty("ChargeType")]
        public string ChargeType { get; set; }
        [JsonProperty("CancellationCharge")]
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
