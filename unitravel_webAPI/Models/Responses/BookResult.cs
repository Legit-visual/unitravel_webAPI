using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class BookResult
    {
        [JsonProperty("status")]
        public StatusObject Status { get; set; }
        [JsonProperty("clientReferenceId")]
        public string ClientReferenceId { get; set; }
        [JsonProperty("confirmationNumber")]
        public string ConfirmationNumber { get; set; }

        public BookResult()
        {
            Status = new StatusObject();
            ClientReferenceId = string.Empty;
            ConfirmationNumber = string.Empty;
        }

        public BookResult(StatusObject status, string clientReferenceId, string confirmationNumber)
        {
            Status = status;
            ClientReferenceId = clientReferenceId;
            ConfirmationNumber = confirmationNumber;
        }
    }
}
