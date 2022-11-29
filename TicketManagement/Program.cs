using System;
using System.Collections.Generic;
using System.Linq;
using TicketManagement.Models;

namespace TicketManagement.Logic
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
            EventsManager Events = new EventsManager(stadium);
            List<Event> listAfterSearch = new();
            do
            {
                MainMenu mainMenu = new MainMenu();
                UserMenu UserMenu = new UserMenu();
                var Choice = mainMenu.Show();
                switch (Choice)
                {
                    case "1":


                        var userChoice = UserMenu.Show();
                        if (userChoice == "1")
                        {
                            ShowTheListEvent(Events.ListEvents);
                            Sale(Events.ListEvents, Events);
                        }
                        else
                        {

                            Char charforSearch = TestOfString("Whice event ar yor search")[0];
                            Char.ToUpper(charforSearch);
                            listAfterSearch = SearchForEventByName(Events.ListEvents, charforSearch);
                            ShowTheListEvent(listAfterSearch);

                            string buyOrNot = TestOfString("To go to buy press 1 \n  to see all event press 2 \n to search another 3");
                            if (buyOrNot == "1")
                            {
                               Sale(listAfterSearch, Events);
                            }
                            else if (buyOrNot == "2")
                            {
                                ShowTheListEvent(Events.ListEvents);
                            }
                            else if (buyOrNot == "3")
                            {
                                SearchForEventByName(Events.ListEvents, charforSearch);
                                Char.ToUpper(charforSearch);
                            }
                        }


                        break;

                    case "2":
                        Console.WriteLine("To canceling , you must enter details");
                        Person person = CreateAPerson();
                        Events.OrderCanceling(person);
                        break;

                    case "3":
                        string eventName = TestOfString("Waht is the name of event");
                        string date = TestOfString("What is the date of the event?");
                        string stadiumName = TestOfString("Waht your name event ?");
                        int numberOfSeats = TestOfInt("What is the number of seats in the stadium?");
                        Events.AndNewEvent(eventName, date, stadiumName, numberOfSeats);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Choose an event and press Enter:");
                        ShowTheListEvent(Events.ListEvents);
                        Event eve =selectedEvent(Events.ListEvents);
                        int numberTicket = Events.AmountOfTickets(eve);
                        Console.WriteLine("Amount Of Tickets:"+" "+ numberTicket);
                        break;


                }
                if (Choice.ToLower() == "q")
                    break;

            } while (true);

        }

        static void Sale(List<Event> events, EventsManager ev)
        {
            Console.WriteLine("Choose an event and press Enter:");
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
