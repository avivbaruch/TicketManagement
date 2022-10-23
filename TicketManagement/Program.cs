using System;
using System.Collections.Generic;

namespace TicketManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            date.ToString("dddd, dd MMMM yyyy");
            Stadium s = new Stadium(3000, "sami ofer");
            Person aviv = new Person("david", "shalom", 224817321);
            Event evet = new Event(s);
            evet.ByTicket(2, aviv);
   
        }
    }
}
