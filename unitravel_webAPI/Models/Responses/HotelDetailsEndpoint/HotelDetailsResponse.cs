using Newtonsoft.Json;
using unitravel_webAPI.Helpers;

namespace unitravel_webAPI.Models.Responses.HotelDetails
{
    public class HotelDetailsResponse
    {
        [JsonProperty("status")]
        public StatusObject Status { get; set; }
        [JsonProperty("hotelDetails")]
        [JsonConverter(typeof(SingleValueArrayConverter<DetailedHotelDetails>))]
        public List<DetailedHotelDetails> HotelDetails { get; set; }

        public HotelDetailsResponse()
        {
            Status = new StatusObject();
            HotelDetails = new List<DetailedHotelDetails>();
        }
    }
}
