namespace unitravel_webAPI.Models.Responses
{
    public class StatusObject
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public StatusObject()
        {
            Code = 400;
            Description = "Object created, but not used properly.";
        }
    }
}
