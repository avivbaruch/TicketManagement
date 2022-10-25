using System;
using System.Collections.Generic;

namespace TicketManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stadium s = new Stadium(5, "sami ofer");
            //Event evet = new Event(s);

            //Person david = new Person("david", "shalom", 224817321);
            //Person aviv = new Person("aviv", "chen", 321547893);
            //Person haim = new Person("haim", "heler", 123456789);


            //evet.ByTicket(20, aviv);
            //evet.ByTicket(3, david);
            //evet.ByTicket(3, david);
            //evet.ByTicket(1, haim);
            //evet.OrderCanceling(aviv,1);
            Char ch = ' ';
            while(ch!='Q')
                {

                MainMenu mainMenu = new MainMenu();
                var userChoice = mainMenu.Show();
                if (userChoice == "1")
                {
                    //Buy Ticket
                    //Print a menu that allows users to choose a ticket
                    //var eventNumber = eventsMenu.Show();
                    foreach (var _event in events)
                    {
                        if (_event.Id == eventNumber)
                        { 
                        //Code that allows to buy a ticket for the current event
                        }
                    }
                }
            }

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
}
