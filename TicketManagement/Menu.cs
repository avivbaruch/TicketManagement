using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Menu
    {
        protected List<string> options = new List<string>();

        public string Show() {
            Console.Clear();
            Console.WriteLine("Choose an option and press Enter:");
            for (int i = 0; i < options.Count; i++)
            {

                Console.WriteLine((i + 1)+" " + options[i]);
            }

            return Console.ReadLine();
        }
     
    }


}
