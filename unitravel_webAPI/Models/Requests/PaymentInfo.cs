using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class PaymentInfo
    {
        [JsonProperty("CvvNumber")]
        public string CvvNumber { get; set; }
        [JsonProperty("CardNumber")]
        public string CardNumber { get; set; }
        [JsonProperty("CardExpirationMonth")]
        public string CardExpirationMonth { get; set; }
        [JsonProperty("CardExpirationYear")]
        public string CardExpirationYear { get; set; }
        [JsonProperty("CardHolderFirstName")]
        public string CardHolderFirstName { get; set; }
        [JsonProperty("CardHolderlastName")]
        public string CardHolderlastName { get; set; }
        [JsonProperty("BillingAmount")]
        public decimal BillingAmount { get; set; }
        [JsonProperty("BillingCurrency")]
        public string BillingCurrency { get; set; }
        [JsonProperty("CardHolderAddress")]
        public CardHolderAddress CardHolderAddress { get; set; }

        public PaymentInfo()
        {
            CvvNumber = string.Empty;
            CardNumber = string.Empty;
            CardExpirationMonth = string.Empty;
            CardExpirationYear = string.Empty;
            CardHolderFirstName = string.Empty;
            CardHolderlastName = string.Empty;
            BillingAmount = decimal.Zero;
            BillingCurrency = string.Empty;
            CardHolderAddress = new CardHolderAddress();
        }

        public PaymentInfo(string cvvNumber, string cardNumber, string cardExpirationMonth, string cardExpirationYear, string cardHolderFirstName, string cardHolderlastName, decimal billingAmount, string billingCurrency, CardHolderAddress cardHolderAddress)
        {
            CvvNumber = cvvNumber;
            CardNumber = cardNumber;
            CardExpirationMonth = cardExpirationMonth;
            CardExpirationYear = cardExpirationYear;
            CardHolderFirstName = cardHolderFirstName;
            CardHolderlastName = cardHolderlastName;
            BillingAmount = billingAmount;
            BillingCurrency = billingCurrency;
            CardHolderAddress = cardHolderAddress;
        }
    }
}
