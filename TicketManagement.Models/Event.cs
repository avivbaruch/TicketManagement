using System;
using System.Collections.Generic;
using System.Linq;


namespace TicketManagement.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        private Stadium Stadium { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Person> Customers { get; set; }

        public Event(Stadium stadium)
        {
            this.Stadium = stadium;
            FillTickets();
            Customers = new List<Person>();
        }
        private void FillTickets()
        {
            Tickets = new List<Ticket>(Stadium.NumberOfSeats);
            for (int i = 0; i < Stadium.NumberOfSeats; i++)
            {
                Ticket tick = new Ticket { Id = i, Price = 200.5 };
                Tickets.Add(tick);
            }
        }

        //public bool BuyTickets(Person Customer, int NumberOfTicket)
        //{
        //    if (this.Tickets.Count == 0)
        //    {
        //        Console.WriteLine("All tickets for this event are sold out");
        //    }
        //    if (Tickets.Count > 0)
        //    {
        //        if (NumberOfTicket > Tickets.Count)
        //        {
        //            Console.WriteLine($" Can't buy tickets, only {this.Tickets.Count} tickets left");
        //        }
        //        else
        //        {
        //            for (int i = 0; i < NumberOfTicket; i++)
        //            {
        //                Ticket tick = new Ticket { Id = i, Price = 200.5 };
        //                Tickets.Remove(Tickets[0]);
        //            }
        //            Console.WriteLine($" Helo {Customer.FirstName} Buy Secceesfully");
        //            this.Customers.Add(Customer);
        //        }
        //    }
        //    return true;
        //}
        //public void OrderCanceling(Person Customer)
        //{
        //    var CustomerToCancel = Customers.FirstOrDefault(c => c.Id == Customer.Id);
        //    if (CustomerToCancel != null)
        //    {
        //        Customers.Remove(CustomerToCancel);
        //    }
        //    Console.WriteLine("Incorrect details");

        //}

    }
}