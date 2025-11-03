using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class SearchResult
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("HotelResult")]
        public List<HotelResult>? HotelResults { get; set; }

        public SearchResult()
        {
            Status = new StatusObject();
            HotelResults = null;
        }

        public SearchResult(StatusObject status, List<HotelResult>? hotelResults)
        {
            Status = status;
            HotelResults = hotelResults;
        }
    }


}
