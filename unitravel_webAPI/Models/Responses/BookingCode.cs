namespace unitravel_webAPI.Models.Responses
{
    public class BookingCode
    {
        public string Code { get; set; }

        public BookingCode()
        {
            Code = string.Empty;
        }

        public BookingCode(string code)
        {
            Code = code;
        }
    }
}
