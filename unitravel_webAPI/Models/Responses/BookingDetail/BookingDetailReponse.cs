using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses.BookingDetail
{
    public class BookingDetailReponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("BookingDetail")]
        public BookingDetail BookingDetail { get; set; }

        public BookingDetailReponse()
        {
            Status = new StatusObject();
            BookingDetail = new BookingDetail();
        }

        public BookingDetailReponse(StatusObject status, BookingDetail bookingDetail)
        {
            Status = status;
            BookingDetail = bookingDetail;
        }
    }
}
