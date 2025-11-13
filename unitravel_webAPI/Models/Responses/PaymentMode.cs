namespace unitravel_webAPI.Models.Responses
{
    public class PaymentMode
    {
        public string PaymentCode { get; set; }
        public string PaymentName { get; set; }
        public string Currency { get; set; }

        public PaymentMode()
        {
            PaymentCode = string.Empty;
            PaymentName = "Limit";
            Currency = string.Empty;
        }

        public PaymentMode(string paymentCode, string paymentName, string currency)
        {
            PaymentCode = paymentCode;
            PaymentName = Validate.PaymentMode(paymentName);
            Currency = currency;
        }
    }
}

