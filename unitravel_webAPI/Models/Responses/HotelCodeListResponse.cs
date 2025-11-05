using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelCodeListResponse
    {
        [JsonProperty("HotelCodes")]
        public List<int> HotelCodes { get; set; }

        public HotelCodeListResponse()
        {
            HotelCodes = new List<int>();
        }

        public HotelCodeListResponse(List<int> hotelCodes)
        {
            HotelCodes = hotelCodes;
        }
    }
}
