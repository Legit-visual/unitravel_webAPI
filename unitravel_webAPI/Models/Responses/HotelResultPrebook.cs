using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelResultPrebook
    {
        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
        [JsonProperty("Currency")]
        public string Currency { get; set; }
        [JsonProperty("Rooms")]
        public List<HotelRooms>? HotelRooms { get; set; }
        [JsonProperty("RateConditions")]
        public List<string> RateConditions { get; set; }
        [JsonProperty("CreditCardBillingOptions")]
        public List<CreditCardBillingOptions> CreditCardBillingOptions { get; set; }

        public HotelResultPrebook()
        {
            HotelCode = string.Empty;
            Currency = string.Empty;
            HotelRooms = null;
            RateConditions = new List<string>();
            CreditCardBillingOptions = new List<CreditCardBillingOptions>();
        }

        public HotelResultPrebook(string hotelCode, string currency, List<HotelRooms>? hotelRooms,List<string> rateConditions, List<CreditCardBillingOptions> creditCardBillingOptions)
        {
            HotelCode = hotelCode;
            Currency = currency;
            HotelRooms = hotelRooms;
            RateConditions = rateConditions;
            CreditCardBillingOptions = creditCardBillingOptions;
        }
    }
}
