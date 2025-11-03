using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelResult
    {
        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
        [JsonProperty("Currency")]
        public string Currency {  get; set; }
        [JsonProperty("Rooms")]
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
