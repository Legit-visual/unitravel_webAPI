using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelRooms
    {
        [JsonProperty("name")]
        public List<string> RoomName { get; set; }
        [JsonProperty("bookingCode")]
        public string BookingCode { get; set; }
        [JsonProperty("inclusion")]
        public string Inclusion {  get; set; }
        [JsonProperty("dayRates")]
        public List<List<DayRate>> DayRates { get; set; } // by documentation, this should be "List of Arrays", not sure if this is right representation
        [JsonProperty("basePrice")]
        public decimal BasePrice { get; set; }
        [JsonProperty("totalFare")]
        public decimal TotalFare { get; set; }
        [JsonProperty("totalTax")]
        public decimal TotalTax { get; set; }
        [JsonProperty("extraGuestCharges")]
        public decimal ExtraGuestCharges { get; set; }
        [JsonProperty("recommendedSellingRate")]
        public string RecommendedSellingRate { get; set; }
        [JsonProperty("roomPromotion")]
        public List<string> RoomPromotions { get; set; }
        [JsonProperty("cancelPolicies")]
        public List<CancelPolicy>? CancelPolicies { get; set; }
        [JsonProperty("mealType")]
        public string MealType {  get; set; } // only acceptable values - "Breakfast_For_2", "Breakfast_For_1", "All_Inclusive_All_Meal"
        [JsonProperty("isRefundable")]
        public bool IsRefundable { get; set; }
        [JsonProperty("withTransfers")]
        public bool WithTransfers { get; set; }
        [JsonProperty("supplements")]
        public List<List<Supplements>> Supplements { get; set; }

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
            Supplements = new List<List<Supplements>>();
        }

        public HotelRooms(List<string> roomName, string bookingCode, string inclusion, List<List<DayRate>> dayRates, decimal basePrice, decimal totalFare, decimal totalTax, decimal extraGuestCharges, string recommendedSellingRate, List<string> roomPromotions, List<CancelPolicy>? cancelPolicies, string mealType, bool isRefundable, bool withTransfers, List<List<Supplements>> supplements)
        {
            RoomName = roomName;
            BookingCode = bookingCode;
            Inclusion = inclusion;
            DayRates = dayRates;
            BasePrice = basePrice;
            TotalFare = totalFare;
            TotalTax = totalTax;
            ExtraGuestCharges = extraGuestCharges;
            RecommendedSellingRate = recommendedSellingRate;
            RoomPromotions = roomPromotions;
            CancelPolicies = cancelPolicies;
            MealType = mealType;
            IsRefundable = isRefundable;
            WithTransfers = withTransfers;
            Supplements = supplements;
        }
    }
    public class DayRate
    {
        [JsonProperty("basePrice")]
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
