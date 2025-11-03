using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class PrebookResult
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("HotelResult")]
        public List<HotelResultPrebook>? HotelResult { get; set; }

        public PrebookResult()
        {
            Status = new StatusObject();
            HotelResult = null;
        }

        public PrebookResult(StatusObject status, List<HotelResultPrebook>? hotelResult)
        {
            Status = status;
            HotelResult = hotelResult;
        }
    }
}
