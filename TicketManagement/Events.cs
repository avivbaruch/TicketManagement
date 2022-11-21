using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    internal class Events : Event
    {
        public List<Event> ListEvents;

        public Events(Stadium stadium) : base(stadium)
        {
            ListEvents = new List<Event>();
            ListEvents.Add(new Event(stadium) { Name = "Maccbi Tel Aviv VS Hapoel Tel Aviv", Date = DateTime.Now, Id = 1 });
            ListEvents.Add(new Event(stadium) { Name = "Eyal Golan", Date = DateTime.Now, Id = 2 });
            ListEvents.Add(new Event(stadium) { Name = "Omer Adam", Date = DateTime.Now, Id = 3 });
        }

        Stadium CreateStadium()
        {
            int NumberOfSeats = TestOfInt("Waht Number of seats");
            string nameStadium = TestOfString("Waht the stadium name");
            return new Stadium(nameStadium, NumberOfSeats);

        }
        Event CreateEvent()
        {
            string NameEvnet = TestOfString("Waht your name event");
            string date = TestOfString("Waht your date");
            DateTime D = DateTime.Parse(date);
            Stadium stadium = CreateStadium();
            return (new Event(stadium) { Date = D, Name = NameEvnet });

        }

        public void AndNewEvent()
        {
            Event e = CreateEvent();
            ListEvents.Add(e);
        }
        string TestOfString(string qury)
        {
            Console.WriteLine(qury);
            String input = Console.ReadLine();
            string prameter = "";
            if (input != null && input != "")
            {
                prameter = input;
            }
            else
            {
                Console.WriteLine("you have entered data Incorrect");
                TestOfString(qury);
            }
            return prameter;
        }
        static int TestOfInt(string qury)
        {
            Console.WriteLine(qury);
            String input = Console.ReadLine();
            int prameter = 0;
            if (input != null && input != "")
            {
                prameter = int.Parse(input);
            }
            else
            {
                Console.WriteLine("you have entered data Incorrect");
                TestOfInt(qury);
            }
            return prameter;
        }

    }
}
