using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Models;

namespace TicketManagement.Logic
{   public class EventsManager : Event
    {
        public List<Event> ListEvents;

        public EventsManager(Stadium stadium) : base(stadium)
        {
            ListEvents = new List<Event>();
            ListEvents.Add(new Event(stadium) { Name = "Maccbi Tel Aviv VS Hapoel Tel Aviv", Date = DateTime.Now, Id = 1 });
            ListEvents.Add(new Event(stadium) { Name = "Eyal Golan", Date = DateTime.Now, Id = 2 });
            ListEvents.Add(new Event(stadium) { Name = "Omer Adam", Date = DateTime.Now, Id = 3 });
        }

        Stadium CreateStadium(int numberOfSeats, string stadiumName)
        {

            return new Stadium(stadiumName, numberOfSeats);

        }
        Event CreateEvent(string eventName, string date, string stadiumName, int numberOfSeats)
        {
            DateTime d = DateTime.Parse(date);
            Stadium stadium = CreateStadium(numberOfSeats, stadiumName);
            return (new Event(stadium) { Date = d, Name = eventName });
        }
        public void AndNewEvent(string eventName, string date, string stadiumName, int numberOfSeats)
        {
            Event e = CreateEvent(eventName, date, stadiumName, numberOfSeats);
            ListEvents.Add(e);
        }

        public int AmountOfTickets(Event e)
        {
            return e.Tickets.Count();
        }

        public bool BuyTickets(Person Customer, int NumberOfTicket)
        {
            if (this.Tickets.Count == 0)
            {
                Console.WriteLine("All tickets for this event are sold out");
            }
            if (Tickets.Count > 0)
            {
                if (NumberOfTicket > Tickets.Count)
                {
                    Console.WriteLine($" Can't buy tickets, only {this.Tickets.Count} tickets left");
                }
                else
                {
                    for (int i = 0; i < NumberOfTicket; i++)
                    {
                        Ticket tick = new Ticket { Id = i, Price = 200.5 };
                        Tickets.Remove(Tickets[0]);
                    }
                    Console.WriteLine($" Helo {Customer.FirstName} Buy Secceesfully");
                    Customers.Add(Customer);
                }
            }
            return true;
        }
        public void OrderCanceling(Person Customer)
        {
            var CustomerToCancel = Customers.FirstOrDefault(c => c.Id == Customer.Id);
            if (CustomerToCancel != null)
            {
                Customers.Remove(CustomerToCancel);
            }
            Console.WriteLine("Incorrect details");

        }
    }
}
