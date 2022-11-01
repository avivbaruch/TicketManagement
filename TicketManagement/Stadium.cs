using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public class Stadium
    {
        public int id { get; set; }
        public string name { get; set; }
        public int NumberOfSeats{ get; set;}

        public Stadium(int id, string name, int numberOfSeats)
        {
            this.id = id;
            this.name = name;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"{name}";
        }

    }
}
