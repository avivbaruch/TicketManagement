using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class TicketManagement
    {
        private int TicketNumber { get; set; }
        private DateTime date { get; set; }
        private int TicketPrice { get; set; }
        private Loction Loction { get; set; }

        public TicketManagement(int ticketNumber, DateTime date, int ticketPrice, Loction loction)
        {
            TicketNumber = ticketNumber;
            this.date = date;
            this.TicketPrice = ticketPrice;
        }
        
        public void BuyPlace(int TicketNumber, Loction Loction)
        {
            int num = Loction.NumberOfSeats-TicketNumber;
        }
    }

}
