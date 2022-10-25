using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Menu
    {
        protected List<string> options = new List<string>();

        public string Show() {
            Console.Clear();
            Console.WriteLine("Choose an option and press Enter:");
            for (int i = 0; i < options.Count; i++)
            {

                Console.WriteLine((i + 1) + options[i]);
            }

            return Console.ReadLine();
        }


        
        public void menu()
        {
            Console.WriteLine("Wellcome!\n To create an event click 1 \n To buy a ticket for the event click 2");
            int choiseUser = int.Parse(Console.ReadLine());
            switch (choiseUser)
            {
                case 1:
                    Event ev= Admin();
                    break;
                case 2:
                    //User(ev);
                    break;
            }
        }
        public void User()
        {
            Console.WriteLine("to buy ticket press 1.\n to Cancel Order press 2.");
            int choiseUser = int.Parse(Console.ReadLine());
            switch (choiseUser)
            {
                case 1:
                    Console.WriteLine("what your first name");
                    string FirstName = Console.ReadLine();

                    Console.WriteLine("what your last name");
                    string LastName = Console.ReadLine();

                    Console.WriteLine("what your id");
                    int id = int.Parse(Console.ReadLine());
                    Person person = new Person(FirstName, LastName, id);

                    Console.WriteLine("How many tickets do you want?");
                    int AmountOfTickets = int.Parse(Console.ReadLine());

                    evet.ByTicket(AmountOfTickets, person);
                    break;

                case 2:
                    Console.WriteLine("what your first name");
                    string First_Name = Console.ReadLine();

                    Console.WriteLine("what your last name");
                    string Last_Name = Console.ReadLine();

                    Console.WriteLine("what your id");
                    int id2 = int.Parse(Console.ReadLine());
                    Person p = new Person(First_Name, Last_Name, id2);

                    Console.WriteLine("How many tickets do you want to cancel?");
                    int CanceltOfTickets = int.Parse(Console.ReadLine());

                    evet.OrderCanceling(p, CanceltOfTickets);
                    break;


            }
        }
        public Event Admin()
        {
            Console.WriteLine("Where is the event taking place?");
            string NameStadium=Console.ReadLine();
            Console.WriteLine("How many places the place containing");
            int NumberOfSeat = int.Parse(Console.ReadLine());
            Stadium s = new Stadium(NumberOfSeat, NameStadium);
            Event evet = new Event(s);
            return evet;

        }  
    }


    class MainMenu : Menu
    {
        public MainMenu()
        {
            options.Add("Buy Ticket");
            options.Add("Cancel Ticket");
        }
    }
}
