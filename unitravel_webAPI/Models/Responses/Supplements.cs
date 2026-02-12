using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class Supplements
    {
        [JsonProperty("index")]
        public int Index { get; set; } // WATCH OUT! Indexes go from 1 forward, not from 0. This int points to the room, for which is this supplement applicable
        [JsonProperty("type")]
        public string Type { get; set; } // only applicable values: "Included", "AtProperty"
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; } // Use 3 letter codes for the currency

        public Supplements()
        {
            Index = 1;
            Type = string.Empty;
            Description = string.Empty;
            Price = decimal.Zero;
            Currency = string.Empty;
        }

        public Supplements(int index, string type, string description, decimal price, string currency)
        {
            Index = index;
            Type = type;
            Description = description;
            Price = price;
            Currency = currency;
        }
    }
}
