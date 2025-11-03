using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class CardHolderAddress
    {
        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty("AddressLine2")]
        public string AddressLine2 { get; set; }
        [JsonProperty("City")]
        public string City { get; set; }
        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; } // only a 2-letter name for the country 

        public CardHolderAddress()
        {
            AddressLine1 = string.Empty;
            AddressLine2 = string.Empty;
            City = string.Empty;
            PostalCode = string.Empty;
            CountryCode = string.Empty;
        }

        public CardHolderAddress(string addressLine1, string addressLine2, string city, string postalCode, string countryCode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            PostalCode = postalCode;
            CountryCode = countryCode;
        }
    }
}
