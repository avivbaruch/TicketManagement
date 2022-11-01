using System;
using System.Collections.Generic;
using System.Linq;

namespace TicketManagement
{
    public static class EventExtinsions
    {
        public static List<Event> AddEventWithId(this List<Event> list, Event newEvent)
        {
            var lastEvent = list.LastOrDefault();
            if (lastEvent == null)
                newEvent.Id = 1;
            else
                newEvent.Id = lastEvent.Id + 1;

            list.Add(newEvent);
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Stadium stadium = new Stadium(1, "Sami Ofer", 3);
            List<Event> events = new List<Event>();
            events.Add(new Event(stadium) { Name = "Maccbi Tel Aviv VS Hapoel Tel Aviv", Date = DateTime.Now, Id = 1 });
            events.Add(new Event(stadium) { Name = "Eyal Golan", Date = DateTime.Now, Id = 2 });
            events.Add(new Event(stadium) { Name = "Omer Adam", Date = DateTime.Now, Id = 3 });

            //Ticket ticket = new Ticket();
            //Person P = new Person("A","B",3);
            //for (int i = 0; i < 10; i++)
            //{
            //ticket.Person.Add(P);

            //}
            do
            {
                MainMenu mainMenu = new MainMenu();
                var userChoice = mainMenu.Show();
                switch (userChoice)
                {
                    case "1":
                        BuyTicket(events);
                        break;
                }

                if (userChoice.ToLower() == "q")
                    break;

            } while (true);

        }

        private static void BuyTicket(List<Event> events)
        {
            Console.Clear();

            ShowTheListEvent(events);

            Event selectedFromUser = selectedEvent(events);

            Console.Clear();

            if (selectedFromUser == null)
            {
                Console.WriteLine("Worng Id");
                selectedEvent(events);
            }

            if (selectedFromUser.Ticket.Any(t => t.Person.Count >= selectedFromUser.Ticket.Count))
            {
                Console.WriteLine("No Tickets");
            }

            Person person = CreateAPerson();
            Ticket ticket = new Ticket();
            ticket.Person.Add(person);
            Console.WriteLine("Buy Secceesfully");
        }

        static Person CreateAPerson()
        {
            Console.WriteLine("what your first name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("what your last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("what your id");
            int id = int.Parse(Console.ReadLine());
            Person person = new Person(FirstName, LastName, id);
            return person;
        }
        static void ShowTheListEvent(List<Event> events)
            => events.ForEach(e => Console.WriteLine($"{e.Id } {e.Name} {e.Date}"));
        static Event selectedEvent(List<Event> events)
        {
            Console.WriteLine("Choose an event and press Enter:");
            int eventForUser = int.Parse(Console.ReadLine());

            return events.FirstOrDefault(e => e.Id == eventForUser);
        }
        static List<Event> SearchForEventByName(List<Event> events, char value)
            => events.Where(x => x.Name.StartsWith(value)).ToList();

    }

}
