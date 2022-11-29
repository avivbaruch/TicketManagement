using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Id = id;
        }
        public override string ToString()
        {
            return $"name:{FirstName} {LastName} id:{Id}";
        }
    }
}
