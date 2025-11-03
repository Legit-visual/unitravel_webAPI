using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CreditCardBillingOptions
    {
        [JsonProperty("Amount")]
        public decimal Amount { get; set; }
        [JsonProperty("Currency")]
        public string Currency {  get; set; }
        [JsonProperty("ConvenienceCharges")]
        public decimal ConvenienceCharges { get; set; }

        public CreditCardBillingOptions()
        {
            Amount = decimal.Zero;
            Currency = string.Empty;
            ConvenienceCharges = decimal.Zero;
        }

        public CreditCardBillingOptions(decimal amount, string currency, decimal convenienceCharges)
        {
            Amount = amount;
            Currency = currency;
            ConvenienceCharges = convenienceCharges;
        }
    }
}
