namespace EventPlanning
{
    public class Reception : Event
    {
        public string RSVP { get; private set; }

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvp)
            : base(title, description, date, time, address)
        {
            RSVP = rsvp;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Reception\nRSVP: {RSVP}";
        }
    }
}
