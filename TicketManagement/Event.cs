using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Event
    {
        public int id { get; set; }
        public Stadium Loction { get; set; }
        public DateTime date { get; set; }


        List<Person> seat = new List<Person>();

        public Event(int id, Stadium loction)
        {
            this.id = id;
            Loction = loction;
        }

        public void ByTicket(int TicketNumber, Person person)
        {
            int AfterBy = TicketNumber - Loction.NumberOfSeats;
            seat.Add(person);
            date = DateTime.Now;
            date.ToString("dddd, dd MMMM yyyy");
        }
        public void OrderCanceling(Person person, int TicketNumber)
        {
            int AfterCanceling = Loction.NumberOfSeats + TicketNumber;
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
