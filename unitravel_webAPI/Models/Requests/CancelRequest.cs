using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class CancelRequest
    {
        [JsonProperty("ConfirmationNumber")]
        public string ConfirmationNumber { get; set; }
        public CancelRequest()
        {
            ConfirmationNumber = string.Empty;
        }

        public CancelRequest(string confirmationNumber)
        {
            ConfirmationNumber = confirmationNumber;
        }
    }
}
