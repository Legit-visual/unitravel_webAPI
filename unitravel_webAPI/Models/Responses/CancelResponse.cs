using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CancelResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; }
        [JsonProperty("ConfirmationNumber")]
        public string ConfirmationNumber { get; set; }

        public CancelResponse()
        {
            Status = new StatusObject();
            ConfirmationNumber = string.Empty;
        }

        public CancelResponse(StatusObject status, string confirmationNumber)
        {
            Status = status;
            ConfirmationNumber = confirmationNumber;
        }
    }
}
