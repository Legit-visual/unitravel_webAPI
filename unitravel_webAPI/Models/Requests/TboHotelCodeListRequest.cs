using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class TboHotelCodeListRequest
    {
        [JsonProperty("CityCode")]
        public string CityCode { get; set; }
        [JsonProperty("IsDetailedResponse")]
        public bool IsDetailedResponse { get; set; }

        public TboHotelCodeListRequest()
        {
            CityCode = string.Empty;
            IsDetailedResponse = false;
        }

        public TboHotelCodeListRequest(string cityCode, bool isDetailedResponse)
        {
            CityCode = cityCode;
            IsDetailedResponse = isDetailedResponse;
        }
    }
}
