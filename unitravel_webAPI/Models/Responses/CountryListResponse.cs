using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CountryListResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("CountryList")]
        public List<CountryObject> CountryList { get; set; }

        public CountryListResponse()
        {
            Status = new StatusObject();
            CountryList = new List<CountryObject>();
        }

        public CountryListResponse(StatusObject status, List<CountryObject> countryList)
        {
            Status = status;
            CountryList = countryList;
        }
    }
}
