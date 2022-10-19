using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Seat
    {
        private int Price { get; set; }
        private int Id { get; set; }
        private int Loction { get; set; }

        public Seat(int price, int id, int loction)
        {
            Price = price;
            Id = id;
            Loction = loction;
        }
        
    }

}
