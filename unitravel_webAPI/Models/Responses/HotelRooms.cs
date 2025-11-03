using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelRooms
    {
        [JsonProperty("Name")]
        public List<string> RoomName { get; set; }
        [JsonProperty("BookingCode")]
        public string BookingCode { get; set; }
        [JsonProperty("Inclusion")]
        public string Inclusion {  get; set; }
        [JsonProperty("DayRates")]
        public List<List<DayRate>> DayRates { get; set; } // by documentation, this should be "List of Arrays", not sure if this is right representation
        [JsonProperty("BasePrice")]
        public decimal BasePrice { get; set; }
        [JsonProperty("TotalFare")]
        public decimal TotalFare { get; set; }
        [JsonProperty("TotalTax")]
        public decimal TotalTax { get; set; }
        [JsonProperty("ExtraGuestCharges")]
        public decimal ExtraGuestCharges { get; set; }
        [JsonProperty("RecommendedSellingRate")]
        public string RecommendedSellingRate { get; set; }
        [JsonProperty("RoomPromotion")]
        public List<string> RoomPromotions { get; set; }
        [JsonProperty("CancelPolicies")]
        public List<CancelPolicy>? CancelPolicies { get; set; }
        [JsonProperty("MealType")]
        public string MealType {  get; set; } // only acceptable values - "Breakfast_For_2", "Breakfast_For_1", "All_Inclusive_All_Meal"
        [JsonProperty("IsRefundable")]
        public bool IsRefundable { get; set; }
        [JsonProperty("WithTransfers")]
        public bool WithTransfers { get; set; }
        [JsonProperty("Supplements")]
        public List<Supplements> Supplements { get; set; }

        public HotelRooms()
        {
            RoomName = new List<string>();
            BookingCode = string.Empty;
            Inclusion = string.Empty;
            DayRates = new List<List<DayRate>>();
            BasePrice = decimal.Zero;
            TotalFare = decimal.Zero;
            TotalTax = decimal.Zero;
            ExtraGuestCharges = decimal.Zero;
            RecommendedSellingRate = string.Empty;
            RoomPromotions = new List<string>();
            CancelPolicies = null;
            MealType = string.Empty;
            IsRefundable = false;
            WithTransfers = false;
            Supplements = new List<Supplements>();
        }

    }
    public class DayRate
    {
        [JsonProperty("BasePrice")]
        public decimal BasePrice { get; set; }
        public DayRate()
        {
           BasePrice = decimal.Zero;
        }

        public DayRate(decimal basePrice)
        {
            BasePrice = basePrice;
        }
    }
}
