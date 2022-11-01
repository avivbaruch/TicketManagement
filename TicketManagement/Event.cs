using System;
using System.Collections.Generic;

namespace TicketManagement
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        private Stadium Stadium { get; set; }
        public List<Ticket> Ticket { get; set; }

        public Event(Stadium stadium)
        {
            Stadium = stadium;
            FillTickets();
        }
        private void FillTickets()
        {
            Ticket = new List<Ticket>(Stadium.NumberOfSeats);
            for (int i = 0; i < Stadium.NumberOfSeats; i++)
            {
                Ticket tick = new Ticket { Id = i, Price = 200.5 };
            }
        }
    }
}