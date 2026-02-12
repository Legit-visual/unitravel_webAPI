using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class BookingDetailObject
    {
        [JsonProperty("index")]
        public string Index {  get; set; }
        [JsonProperty("bookingId")]
        public string BookingId { get; set; }
        [JsonProperty("confirmationNo")]
        public string ConfirmationNo { get; set; }
        [JsonProperty("bookingDate")]
        public string BookingDate { get; set; }
        [JsonProperty("currency")]
        public string Currency {  get; set; }
        [JsonProperty("agentMarkup")]
        public string AgentMarkup { get; set; }
        [JsonProperty("agencyName")]
        public string AgencyName { get; set; }
        [JsonProperty("bookingPrice")]
        public string BookingPrice { get; set; }
        [JsonProperty("tripName")]
        public string TripName { get; set; }
        [JsonProperty("TBOHotelCode")]
        public string TBOHotelCode { get; set; }
        [JsonProperty("checkInDate")]
        public string CheckInDate { get; set; }
        [JsonProperty("checkOutDate")]
        public string CheckOutDate { get; set; }
        [JsonProperty("clientReferenceNumber")]
        public string ClientReferenceNumber { get; set; }

        public BookingDetailObject()
        {
            Index = string.Empty;
            BookingId = string.Empty;
            ConfirmationNo = string.Empty;
            BookingDate = string.Empty;
            Currency = string.Empty;
            AgentMarkup = string.Empty;
            AgencyName = string.Empty;
            BookingPrice = string.Empty;
            TripName = string.Empty;
            TBOHotelCode = string.Empty;
            CheckInDate = string.Empty;
            CheckOutDate = string.Empty;
            ClientReferenceNumber = string.Empty;
        }

        public BookingDetailObject(string index, string bookingId, string confirmationNo, string bookingDate, string currency, string agentMarkup, string agencyName, string bookingPrice, string tripName, string tBOHotelCode, string checkInDate, string checkOutDate, string clientReferenceNumber)
        {
            Index = index;
            BookingId = bookingId;
            ConfirmationNo = confirmationNo;
            BookingDate = bookingDate;
            Currency = currency;
            AgentMarkup = agentMarkup;
            AgencyName = agencyName;
            BookingPrice = bookingPrice;
            TripName = tripName;
            TBOHotelCode = tBOHotelCode;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            ClientReferenceNumber = clientReferenceNumber;
        }
    }
}
