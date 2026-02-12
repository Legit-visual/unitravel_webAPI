namespace unitravel_webAPI.Models.Responses
{
    public class SupplementInnerObject
    {
        public List<Supplements> Supplements { get; set; }

        public SupplementInnerObject(List<Supplements> supplements)
        {
            Supplements = supplements;
        }

        public SupplementInnerObject()
        {
            Supplements = new List<Supplements>();
        }
    }
}
