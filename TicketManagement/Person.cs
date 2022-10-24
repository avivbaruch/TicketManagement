using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public int id { get; set; }

        public Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            this.id = id;
        }
        public override string ToString()
        {
            return $"name:{FirstName} {LastName} id:{id}";
        }
    }
}
