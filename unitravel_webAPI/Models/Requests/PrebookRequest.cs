using Newtonsoft.Json;
using System.Text.Json;
using unitravel_webAPI.Models.Responses;

namespace unitravel_webAPI.Models.Requests
{
    public class PrebookRequest
    {
        [JsonProperty("BookingCode")]
        public string BookingCode { get; set; }
        [JsonProperty("PaymentMode")]
        public string PaymentMode { get; set; }

        public PrebookRequest()
        {
            BookingCode = string.Empty;
            PaymentMode = "Limit";
        }

        public PrebookRequest(string bookingCode, string paymentMode)
        {
            BookingCode = bookingCode;
            PaymentMode = Validate.PaymentMode(paymentMode);
        }
    }
}
