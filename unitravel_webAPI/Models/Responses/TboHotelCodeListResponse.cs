using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class TboHotelCodeListResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status {  get; set; }
        [JsonProperty("Hotels")]
        public List<HotelObject> Hotels { get; set; }

        public TboHotelCodeListResponse()
        {
            Status = new StatusObject();
            Hotels = new List<HotelObject>();
        }

        public TboHotelCodeListResponse(StatusObject status, List<HotelObject> hotels)
        {
            Status = status;
            Hotels = hotels;
        }
    }
}
