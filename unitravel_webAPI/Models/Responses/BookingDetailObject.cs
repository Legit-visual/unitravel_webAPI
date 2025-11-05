using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class BookingDetailObject
    {
        [JsonProperty("Index")]
        public string Index {  get; set; }
        [JsonProperty("BookingId")]
        public string BookingId { get; set; }
        [JsonProperty("ConfirmationNo")]
        public string ConfirmationNo { get; set; }
        [JsonProperty("BookingDate")]
        public string BookingDate { get; set; }
        [JsonProperty("Currency")]
        public string Currency {  get; set; }
        [JsonProperty("AgentMarkup")]
        public string AgentMarkup { get; set; }
        [JsonProperty("AgencyName")]
        public string AgencyName { get; set; }
        [JsonProperty("BookingPrice")]
        public string BookingPrice { get; set; }
        [JsonProperty("TripName")]
        public string TripName { get; set; }
        [JsonProperty("TBOHotelCode")]
        public string TBOHotelCode { get; set; }
        [JsonProperty("CheckInDate")]
        public string CheckInDate { get; set; }
        [JsonProperty("CheckOutDate")]
        public string CheckOutDate { get; set; }
        [JsonProperty("ClientReferenceNumber")]
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
