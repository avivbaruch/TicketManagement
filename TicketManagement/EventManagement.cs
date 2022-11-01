using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class EventManagement
    {
        public int id { get; set; }
        private int OrderNumber { get; set; }
        private Stadium Loction { get; set; }
        private DateTime date { get; set; }
        private int NumberOfSales { get; set; }
        private int NumberOfPlacesLeft { get; set; }
        public EventManagement(Stadium loction)
        {
            OrderNumber = 500;
            Loction = loction;
            NumberOfSales = 0;
            date = DateTime.Now;
            NumberOfPlacesLeft = loction.NumberOfSeats;
        }

        List<Person> seat = new List<Person>();

        public void ByTicket(int NumberOfTicket, Person person)
        {
            if (NumberOfPlacesLeft <= Loction.NumberOfSeats && NumberOfTicket <= NumberOfPlacesLeft)
            {
                seat.Add(person);
                date = DateTime.Now;
                date.ToString("dddd, dd MMMM yyyy");
                NumberOfSales += NumberOfTicket;
                NumberOfPlacesLeft -= NumberOfTicket;
                Console.WriteLine($"There are:{NumberOfPlacesLeft} places left ");
            }
            else
            {
                Console.WriteLine("There are no places for the show");
            }

        }
        public void OrderCanceling(Person person, int TicketNumber)
        {
            NumberOfPlacesLeft += TicketNumber;
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
