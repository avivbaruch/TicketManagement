using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    internal class Events : Event
    {
        private List<Event> ListEvents;

        public Events(Stadium stadium, int id, string name, DateTime date) : base(stadium)
        {
        }

        Stadium CreateStadium()
        {
            int NumberOfSeats = TestOfInt("Waht Number of seats");
            string nameStadium = TestOfString("Waht the stadium name");
            return new Stadium(nameStadium, NumberOfSeats);

        }
        Event CreateEvent()
        {
            int id = TestOfInt("Waht id of your event");
            string NameEvnet = TestOfString("Waht your name event");
            string date = TestOfString("Waht your date");
            DateTime D = DateTime.Parse(date);
            Stadium stadium =CreateStadium();
            return (new Event(stadium) { Date= D ,Name= NameEvnet,Id= id});

        }

        void AndNewEvent()
        {
            Event e = CreateEvent();
            ListEvents.Add(e);
        }
        string TestOfString(string qury)
        {
            Console.WriteLine(qury);
            String input = Console.ReadLine();
            string prameter = "";
            if (input != null && input != " ")
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
            if (input != null && input != " ")
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
