using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.UI
{
    internal class ConsoleHelper
    {
       static string TestOfString(string qury)
        {
            Console.WriteLine(qury);
            String input = Console.ReadLine();
            string prameter = "";
            if (input != null && input != "")
            {
                prameter = input;
            }
            else
            {
                Console.WriteLine("you have entered data Incorrect");
                TestOfString(qury);
            }
            return prameter;
        }
       static int TestOfInt(string qury)
        {
            Console.WriteLine(qury);
            String input = Console.ReadLine();
            int prameter = 0;
            if (input != null && input != "")
            {
                prameter = int.Parse(input);
            }
            else
            {
                Console.WriteLine("you have entered data Incorrect");
                TestOfInt(qury);
            }
            return prameter;
        }

    }
}
