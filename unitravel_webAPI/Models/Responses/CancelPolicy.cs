namespace unitravel_webAPI.Models.Responses
{
    public class CancelPolicy
    {
        public string Index {  get; set; }
        public string FromDate { get; set; } // using YYYY-MM-DD format
        public string ChargeType { get; set; }
        public decimal CancallationCharge { get; set; }

        public CancelPolicy()
        {
            Index = string.Empty;
            FromDate = string.Empty;
            ChargeType = string.Empty;
            CancallationCharge = 0;
        }
    }
}
