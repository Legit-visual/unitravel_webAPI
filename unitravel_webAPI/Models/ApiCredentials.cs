namespace unitravel_webAPI.Models
{
    public class ApiCredentials
    {
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
