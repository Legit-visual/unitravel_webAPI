using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelBookingDetailBasedOnDateResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("BookingDetail")]
        public List<BookingDetailObject> BookingDetail { get; set; }

        public HotelBookingDetailBasedOnDateResponse()
        {
            Status = new StatusObject();
            BookingDetail = new List<BookingDetailObject>();
        }

        public HotelBookingDetailBasedOnDateResponse(StatusObject status, List<BookingDetailObject> bookingDetail)
        {
            Status = status;
            BookingDetail = bookingDetail;
        }
    }
}
