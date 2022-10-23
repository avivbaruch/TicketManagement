using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Event
    {
        public int OrderNumber { get; set; }
        public Stadium Loction { get; set; }
        public DateTime date { get; set; }
        public int TicketNumber { get; set; }

        public Event()
        {
            OrderNumber = 0;
            TicketNumber = Loction.NumberOfSeats;
        }

        List<Person> seat = new List<Person>();

        public Event(Stadium loction)
        {
            Loction = loction;
        }

        public void ByTicket(int TicketNumber, Person person)
        {
            while (this.TicketNumber < Loction.NumberOfSeats)
            {
                this.TicketNumber = Loction.NumberOfSeats - TicketNumber;
                seat.Add(person);
                date = DateTime.Now;
                date.ToString("dddd, dd MMMM yyyy");
                OrderNumber++;
            }
            Console.WriteLine("There are no places for the show");

        }
        public void OrderCanceling(Person person, int TicketNumber)
        {
            this.TicketNumber = Loction.NumberOfSeats + TicketNumber;
            if (seat == null)
            {
                Console.WriteLine("the list is null");
            }
            else
            {
                Person Remove = seat.Find(x => x.id == person.id);
                seat.Remove(Remove);
            }

        }
    }
}
