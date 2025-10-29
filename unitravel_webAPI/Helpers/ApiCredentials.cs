namespace unitravel_webAPI.Helpers
{
    public class ApiCredentials
    {
        public string BaseUrl { get; set; } = "";
        public string Username { get; set; }
        public string Password { get; set; }

        public ApiCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public ApiCredentials()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
