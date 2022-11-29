using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class MainMenu : Menu
    {
        public MainMenu()
        {
            options.Add("Buy Ticket");
            options.Add("Cancel Ticket");
            options.Add("Add Event");
            options.Add("To see the amount of ticket");
        }

    }
}
