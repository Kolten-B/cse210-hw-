using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create events
            Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", new DateTime(2024, 8, 10), "10:00 AM", new Address("123 Tech St", "Tech City", "CA", "USA"), "John Doe", 100);
            Reception reception = new Reception("Company Meetup", "Annual company meetup", new DateTime(2024, 9, 15), "5:00 PM", new Address("456 Business Rd", "Business City", "NY", "USA"), "rsvp@company.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "Company picnic in the park", new DateTime(2024, 7, 25), "12:00 PM", new Address("789 Park Ave", "Park City", "TX", "USA"), "Sunny");

            // List of events
            Event[] events = new Event[] { lecture, reception, outdoorGathering };

            // Display event details
            foreach (var ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine("Full Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
            }
        }
    }
}
