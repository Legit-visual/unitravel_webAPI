using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses.HotelDetails
{
    public class HotelDetailsResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("HotelDetails")]
        public List<DetailedHotelDetails> HotelDetails { get; set; }

        public HotelDetailsResponse()
        {
            Status = new StatusObject();
            HotelDetails = new List<DetailedHotelDetails>();
        }

        public HotelDetailsResponse(StatusObject status, List<DetailedHotelDetails> hotelDetails)
        {
            Status = status;
            HotelDetails = hotelDetails;
        }
    }
}
