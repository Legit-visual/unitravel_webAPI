﻿namespace unitravel_webAPI.Models.Responses
{
    public class Supplements
    {
        public int Index { get; set; } // WATCH OUT! Indexes go from 1 forward, not from 0. This int points to the room, for which is this supplement applicable
        public string Type { get; set; } // only applicable values: "Included", "AtProperty"
        public string Description { get; set; }
        public decimal Price { get; set; }
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
