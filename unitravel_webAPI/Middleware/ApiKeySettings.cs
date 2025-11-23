namespace unitravel_webAPI.Middleware
{
    public class ApiKeySettings
    {
        public string BridgeApiKey { get; set; }

        public ApiKeySettings(string bridgeApiKey)
        {
            BridgeApiKey = bridgeApiKey;
        }

        public ApiKeySettings()
        {
            BridgeApiKey = string.Empty;
        }
    }
}
