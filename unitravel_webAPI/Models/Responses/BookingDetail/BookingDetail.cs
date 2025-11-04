using Newtonsoft.Json;
using unitravel_webAPI.Models.Requests;

namespace unitravel_webAPI.Models.Responses.BookingDetail
{
    public class BookingDetail
    {
        [JsonProperty("BookingStatus")]
        public string BookingStatus { get; set; }
        [JsonProperty("VoucherStatus")]
        public string VoucherStatus { get; set; }
        [JsonProperty("ConfirmationNumber")]
        public string ConfirmationNumber { get; set; }
        [JsonProperty("HotelConfirmationNumber")]
        public string HotelConfirmationNumber { get; set; }
        [JsonProperty("InvoiceNumber")]
        public string InvoiceNumber { get; set; }
        [JsonProperty("CheckIn")]
        public string CheckIn {  get; set; }
        [JsonProperty("CheckOut")]
        public string CheckOut { get; set; }
        [JsonProperty("BookingDate")]
        public string BookingDate { get; set; }
        [JsonProperty("NoOfRooms")]
        public int NoOfRooms { get; set; }
        [JsonProperty("HotelDetails")]
        public HotelDetails HotelDetails { get; set; }
        [JsonProperty("Rooms")]
        public Rooms Rooms { get; set; }
        [JsonProperty("CancelPolicies")]
        public List<CancelPolicy> CancelPolicies { get; set; }
        [JsonProperty("MealType")]
        public string MealType { get; set; }
        [JsonProperty("IsRefundable")]
        public bool IsRefundable { get; set; }
        [JsonProperty("Supplements")]
        public List<Supplements> Supplements { get; set; }
        [JsonProperty("CustomerDetails")]
        public List<CustomerDetails> CustomerDetails { get; set; }
        [JsonProperty("RateConditions")]
        public List<string> RateConditions { get; set; }
        [JsonProperty("CreditCardOptions")]
        public List<string> CreditCardOptions { get; set; }

        public BookingDetail()
        {
            BookingStatus = string.Empty;
            VoucherStatus = string.Empty;
            ConfirmationNumber = string.Empty;
            HotelConfirmationNumber = string.Empty;
            InvoiceNumber = string.Empty;
            CheckIn = string.Empty;
            CheckOut = string.Empty;
            BookingDate = string.Empty;
            NoOfRooms = 0;
            HotelDetails = new HotelDetails();
            Rooms = new Rooms();
            CancelPolicies = new List<CancelPolicy>();
            MealType = string.Empty;
            IsRefundable = false;
            Supplements = new List<Supplements>();
            CustomerDetails = new List<CustomerDetails>();
            RateConditions = new List<string>();
            CreditCardOptions = new List<string>();
        }

        public BookingDetail(string bookingStatus, string voucherStatus, string confirmationNumber, string hotelConfirmationNumber, string invoiceNumber, string checkIn, string checkOut, string bookingDate, int noOfRooms, HotelDetails hotelDetails, Rooms rooms, List<CancelPolicy> cancelPolicies, string mealType, bool isRefundable, List<Supplements> supplements, List<CustomerDetails> customerDetails, List<string> rateConditions, List<string> creditCardOptions)
        {
            BookingStatus = bookingStatus;
            VoucherStatus = voucherStatus;
            ConfirmationNumber = confirmationNumber;
            HotelConfirmationNumber = hotelConfirmationNumber;
            InvoiceNumber = invoiceNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
            BookingDate = bookingDate;
            NoOfRooms = noOfRooms;
            HotelDetails = hotelDetails;
            Rooms = rooms;
            CancelPolicies = cancelPolicies;
            MealType = mealType;
            IsRefundable = isRefundable;
            Supplements = supplements;
            CustomerDetails = customerDetails;
            RateConditions = rateConditions;
            CreditCardOptions = creditCardOptions;
        }
    }
}
