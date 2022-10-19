using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Loction
    {
        public int Place { get; set; }
        public int NumberOfSeats { get; set; }


        public Loction(int place,int number)
        {
            Place = place;
            this.NumberOfSeats = number;
        }
    }
}
