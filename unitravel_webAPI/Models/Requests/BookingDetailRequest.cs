using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class BookingDetailRequest
    {
        [JsonProperty("ConfirmationNumber")]
        public string? ConfirmationNumber { get; set; }
        [JsonProperty("BookingReferenceId")]
        public string? BookingReferenceId { get; set; }
        [JsonProperty("PaymentMode")]
        public string PaymentMode { get; set; }

        public BookingDetailRequest()
        {
            ConfirmationNumber = string.Empty;
            BookingReferenceId = string.Empty;
            PaymentMode = string.Empty;
        }

        public BookingDetailRequest(string? confirmationNumber, string? bookingReferenceId, string paymentMode)
        {
            ConfirmationNumber = confirmationNumber;
            BookingReferenceId = bookingReferenceId;
            PaymentMode = paymentMode;
        }
    }
}
