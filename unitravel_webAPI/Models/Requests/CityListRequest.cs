using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class CityListRequest
    {
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        public CityListRequest()
        {
            CountryCode = string.Empty;
        }

        public CityListRequest(string countryCode)
        {
            CountryCode = countryCode;
        }
    }
}
