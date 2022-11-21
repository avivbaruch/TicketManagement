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
            Stadium stadium = new Stadium("Sami Ofer", 3);
            Events Events = new Events(stadium);

            do
            {
                MainMenu mainMenu = new MainMenu();
                var userChoice = mainMenu.Show();

                switch (userChoice)
                {
                    case "1":
                        Sale(Events.ListEvents, Events);
                        break;

                    case "2":
                        Console.WriteLine("To canceling , you must enter details");
                        Person person = CreateAPerson();
                        Events.OrderCanceling(person);
                        break;

                    case "3":
                        Events.AndNewEvent();
                        break;

                }


                if (userChoice.ToLower() == "q")
                    break;

            } while (true);

        }

        private static void Sale(List<Event> events, Event ev)
        {
            Console.Clear();
            Console.WriteLine("Choose an event and press Enter:");
            ShowTheListEvent(events);

            Event selectedFromUser = selectedEvent(events);

            Console.Clear();

            while (selectedFromUser == null)
            {
                Console.WriteLine("Worng Id");
                ShowTheListEvent(events);
                selectedFromUser = selectedEvent(events);
                Console.Clear();
            }

            Console.WriteLine("To continue buying, you must enter details");
            Person person = CreateAPerson();

            Console.WriteLine("How many tickets do you want?");
            int numTicket = int.Parse(Console.ReadLine());

            ev.BuyTickets(person, numTicket);

            //Console.WriteLine($" Helo {person.FirstName} Buy Secceesfully-Buying tickets for the show:\n name event:{selectedFromUser.Name}\n date:{selectedFromUser.Date}");
            Console.WriteLine("To exit press Q \nTo buy more tickets press enter");
            Console.ReadLine();
        }

        static Person CreateAPerson()
        {
            string FirstName = TestOfString("what your first name");

            string LastName = TestOfString("what your last name");

            int id = TestOfInt("what your id");
            Person person = new Person(FirstName, LastName, id);
            return person;
        }
        static void ShowTheListEvent(List<Event> events)
            => events.ForEach(e => Console.WriteLine($"{e.Id } {e.Name} {e.Date}"));
        static Event selectedEvent(List<Event> events)
        {
            String input = Console.ReadLine();
            int eventForUser = 0;
            if (input != null && input != "")
            {
                eventForUser = int.Parse(input);
            }
            return events.FirstOrDefault(e => e.Id == eventForUser);
        }
        static List<Event> SearchForEventByName(List<Event> events, char value)
            => events.Where(x => x.Name.StartsWith(value)).ToList();

        static string TestOfString(string qury)
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
