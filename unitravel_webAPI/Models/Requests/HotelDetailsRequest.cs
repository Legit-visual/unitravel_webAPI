using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class HotelDetailsRequest
    {
        [JsonProperty("HotelCodes")]
        public string HotelCodes { get; set; }
        [JsonProperty("Language")]
        public string Language {  get; set; } // should be 2 letter code

        public HotelDetailsRequest()
        {
            HotelCodes = string.Empty;
            Language = string.Empty;
        }

        public HotelDetailsRequest(string hotelCodes, string language)
        {
            HotelCodes = hotelCodes;
            Language = language;
        }
    }
}
