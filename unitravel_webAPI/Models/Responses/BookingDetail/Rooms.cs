using Newtonsoft.Json;
using unitravel_webAPI.Helpers;

namespace unitravel_webAPI.Models.Responses.BookingDetail
{
    public class Rooms
    {
        [JsonProperty("Currency")]
        public string Currency {  get; set; }
        [JsonProperty("Name")]
        public List<string> Name { get; set; }
        [JsonProperty("Inclusion")]
        public string Inclusion { get; set; }
        [JsonProperty("TotalFare")]
        public decimal TotalFare { get; set; }
        [JsonProperty("TotalTax")]
        public decimal TotalTax { get; set; }
        [JsonProperty("RoomPromotion")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> RoomPromotion { get; set; }

        public Rooms()
        {
            Currency = string.Empty;
            Name = new List<string>();
            Inclusion = string.Empty;
            TotalFare = decimal.Zero;
            TotalTax = decimal.Zero;
            RoomPromotion = new List<string>();
        }

        public Rooms(string currency, List<string> name, string inclusion, decimal totalFare, decimal totalTax, List<string> roomPromotion)
        {
            Currency = currency;
            Name = name;
            Inclusion = inclusion;
            TotalFare = totalFare;
            TotalTax = totalTax;
            RoomPromotion = roomPromotion;
        }
    }
}
