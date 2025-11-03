using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class BookRequest
    {
        [JsonProperty("BookingCode")]
        public string BookingCode { get; set; }
        [JsonProperty("CustomerDetails")]
        public List<CustomerDetails> CustomerDetails { get; set; }
        [JsonProperty("ClientReferenceId")]
        public string ClientReferenceId { get; set; }
        [JsonProperty("BookingReferenceId")]
        public string BookingReferenceId { get; set; }
        [JsonProperty("TotalFare")]
        public decimal TotalFare { get; set; }
        [JsonProperty("EmailId")]
        public string EmailId { get; set; }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("BookingType")]
        public string BookingType { get; set; }
        [JsonProperty("PaymentMode")]
        public string PaymentMode { get; set; }
        [JsonProperty("PaymentInfo")]
        public PaymentInfo PaymentInfo { get; set; }

        public BookRequest()
        {
            BookingCode = string.Empty;
            CustomerDetails = new List<CustomerDetails>();
            ClientReferenceId = string.Empty;
            BookingReferenceId = string.Empty;
            TotalFare = decimal.Zero;
            EmailId = string.Empty;
            PhoneNumber = string.Empty;
            BookingType = string.Empty;
            PaymentMode = string.Empty;
            PaymentInfo = new PaymentInfo();
        }

        public BookRequest(string bookingCode,List<CustomerDetails> customerDetails, string clientReferenceId, string bookingReferenceId, decimal totalFare, string emailId, string phoneNumber, string bookingType, string paymentMode, PaymentInfo paymentInfo)
        {
            BookingCode = bookingCode;
            CustomerDetails = customerDetails;
            ClientReferenceId = clientReferenceId;
            BookingReferenceId = bookingReferenceId;
            TotalFare = totalFare;
            EmailId = emailId;
            PhoneNumber = phoneNumber;
            BookingType = bookingType;
            PaymentMode = paymentMode;
            PaymentInfo = paymentInfo;
        }
    }
}
