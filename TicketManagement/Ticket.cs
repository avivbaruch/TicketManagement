using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public class Ticket
    {
        public double Price { get; set; }
        public int Id { get; set; }
        public List<Person> Person { get; set; }

        public Ticket()
        {
            this.Person=new List<Person>();
        }
    }

}
