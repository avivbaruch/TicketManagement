using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class TicketManagement
    {
        public int TicketNumber { get; set; }
        public DateTime date { get; set; }
        public int TicketPrice { get; set; }

        public TicketManagement(int ticketNumber, DateTime date, int ticketPrice)
        {
            TicketNumber = ticketNumber;
            this.date = date;
            TicketPrice = ticketPrice;
        }

     
    }

}
