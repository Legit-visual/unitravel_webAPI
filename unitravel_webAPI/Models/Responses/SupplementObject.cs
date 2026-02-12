using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class SupplementObject
    {
        [JsonProperty("Supplements")]
        public List<SupplementInnerObject> Supplements { get; set; }

        public SupplementObject()
        {
            Supplements = new List<SupplementInnerObject>();
        }

        public SupplementObject(List<SupplementInnerObject> supplements)
        {
            Supplements = supplements;
        }
    }
}
