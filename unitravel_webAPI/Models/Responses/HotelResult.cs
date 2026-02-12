using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelResult
    {
        [JsonProperty("hotelCode")]
        public string HotelCode { get; set; }
        [JsonProperty("currency")]
        public string Currency {  get; set; }
        [JsonProperty("rooms")]
        public List<HotelRooms>? HotelRooms { get; set; }

        public HotelResult()
        {
            HotelCode = string.Empty;
            Currency = string.Empty;
            HotelRooms = null;
        }

        public HotelResult(string hotelCode, string currency, List<HotelRooms>? hotelRooms)
        {
            HotelCode = hotelCode;
            Currency = currency;
            HotelRooms = hotelRooms;
        }
    }
}
