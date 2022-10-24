using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Stadium
    {
        public string name { get; set; }
        public int NumberOfSeats{ get; set;}

        public Stadium(int numberOfSeats, string name)
        {
            NumberOfSeats = numberOfSeats;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}";
        }

    }
}
