using System;
using System.Collections.Generic;

namespace TicketManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> events = new List<string>();
            events.Add("הופעה של ישי ריבו");
            events.Add("הופעה של חיים ישראל");
            events.Add("הופעה אייל גולן");

            Char ch = ' ';

            while (ch != 'Q')
            {
                MainMenu mainMenu = new MainMenu();
                var userChoice = mainMenu.Show();
                if (userChoice == "1")
                {
                    Console.Clear();

                    Console.WriteLine("Choose an event and press Enter:");

                    ShowTheListEvent(events);

                    int EventForUser = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Person person = CreateAPerson();

                    Stadium s = new Stadium(3, "sami ofer");

                    Event evnet = new Event(s);

                    Console.WriteLine("How many tickets do you want?");
                    int AmountOfTickets = int.Parse(Console.ReadLine());
                    evnet.ByTicket(AmountOfTickets, person);
                    Console.Clear();

                    Console.WriteLine("Thanks");
                }
                ch = 'Q';
            }
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
        static void ShowTheListEvent(List<string> events)
        {
            int num = 1;
            foreach (var _event in events)
            {
                Console.WriteLine(num + " " + _event);
                num++;
            }
        };
        static void SearchForEventByName(List<string> events)
        {
            events.Find(x=>x.);
        }

    }

}
