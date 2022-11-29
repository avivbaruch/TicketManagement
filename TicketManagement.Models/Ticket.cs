using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Models
{
    public class Ticket
    {
      
            public double Price { get; set; }
            public int Id { get; set; }
            public Person Person { get; set; }
 
    }

}
