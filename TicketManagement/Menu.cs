using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Menu
    {
       public void menu()
        {
            Stadium s = new Stadium(5,"sami ofer");
            Event evet = new Event(s);
            Console.WriteLine("to buy ticket press 1.\n to Cancel Order press 2.");
            int choiseUser =int.Parse(Console.ReadLine());
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
    }
}
