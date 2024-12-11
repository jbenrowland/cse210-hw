using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(" 3557 Finch St", "Rexburg", "ID", "83440");
        Address address2 = new Address("7257 N 3985 W", "Santa Rosa", "CA", "95401");
        Address address3 = new Address("127 Pine St", "Provo", "UT", "84601");

        Lecture lecture = new Lecture("Tech Trends 2025", "A lecture on emerging tech trends", "2025-01-15", "10:00 AM", address1, "Dr. King", 100);
        
        Reception reception = new Reception("Annual Networking Conference", "An evening of celebration and networking", "2024-12-30", "6:30 PM", address2, "rsvp@networkingevent.com");
        
        OutdoorGathering outdoorEvent = new OutdoorGathering("Winter Festival", "A fun outdoor festival for families", "2025-01-03", "1:00 PM", address3, "Cool with a chance of clouds");

        Event[] events = { lecture, reception, outdoorEvent };

        foreach (Event evt in events)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Standard Details:\n");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n");

            if (evt is Lecture)
            {
                Console.WriteLine(((Lecture)evt).GetFullDetails());
            }
            else if (evt is Reception)
            {
                Console.WriteLine(((Reception)evt).GetFullDetails());
            }
            else if (evt is OutdoorGathering)
            {
                Console.WriteLine(((OutdoorGathering)evt).GetFullDetails());
            }

            Console.WriteLine("\nShort Description:\n");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('=', 50) + "\n");
        }
    }
}
