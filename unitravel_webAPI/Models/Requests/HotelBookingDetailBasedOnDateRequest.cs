using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class HotelBookingDetailBasedOnDateRequest
    {
        [JsonProperty("FromDate")]
        public string FromDate { get; set; }
        [JsonProperty("ToDate")]
        public string ToDate { get; set; }

        public HotelBookingDetailBasedOnDateRequest()
        {
            FromDate = string.Empty;
            ToDate = string.Empty;
        }

        public HotelBookingDetailBasedOnDateRequest(string fromDate, string toDate)
        {
            FromDate = fromDate;
            ToDate = toDate;
        }
    }

}
