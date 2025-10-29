namespace unitravel_webAPI.Models.Requests
{
    public class RoomGuest
    {
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public List<int>? ChildrenAges { get; set; }

        public RoomGuest(int numberOfAdults, int numberOfChildren, List<int>? childrenAges)
        {
            NumberOfAdults = numberOfAdults;
            NumberOfChildren = numberOfChildren;
            ChildrenAges = childrenAges;
        }

        public RoomGuest()
        {
            NumberOfAdults = 0;
            NumberOfChildren = 0;
            ChildrenAges = null;
        }
    }
}
