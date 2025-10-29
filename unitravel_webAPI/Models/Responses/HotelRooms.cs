namespace unitravel_webAPI.Models.Responses
{
    public class HotelRooms
    {
        public List<string> RoomName { get; set; }
        public string BookingCode { get; set; }
        public string Inclusion {  get; set; }
        public List<List<decimal>> DayRates { get; set; } // by documentation, this should be "List of Arrays", not sure if this is right representation
        public decimal BasePrice { get; set; }
        public decimal TotalFare { get; set; }
        public decimal TotalTax { get; set; }
        public decimal ExtraGuestCharges { get; set; }
        public string RecommendedSellingRate { get; set; }
        public List<string> RoomPromotions { get; set; }
        public List<CancelPolicy>? CancelPolicies { get; set; }
        public string MealType {  get; set; } // only acceptable values - "Breakfast_For_2", "Breakfast_For_1", "All_Inclusive_All_Meal"
        public bool IsRefundable { get; set; }
        public bool WithTransfers { get; set; }
        public List<Supplements> Supplements { get; set; }

        public HotelRooms()
        {
            RoomName = new List<string>();
            BookingCode = string.Empty;
            Inclusion = string.Empty;
            DayRates = new List<List<decimal>>();
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
}
