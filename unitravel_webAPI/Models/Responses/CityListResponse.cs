using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CityListResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status {  get; set; }
        [JsonProperty("CityList")]
        public List<CityObject> CityList { get; set; }

        public CityListResponse()
        {
            Status = new StatusObject();
            CityList = new List<CityObject>();
        }

        public CityListResponse(StatusObject status, List<CityObject> cityList)
        {
            Status = status;
            CityList = cityList;
        }
    }
}
