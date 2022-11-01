using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{

    class Main
    {
        public static void Start()
        {
            var stadium = new Stad { Id = 1, Name = "Sami Ofer", Size = 40 };
            var person = new Person("Refael", "Ganesh", 1);

            var events = new List<Even>
                {
                    new Even(stadium)
                    {
                        Date = DateTime.Now,
                        Name = "Maccabi Vs Hpoel",
                        Id = 1
                    }
                };

            events.ForEach(e => Console.WriteLine($"{e.Id} {e.Name} {e.Date}"));

            var selectedEventId = int.Parse(Console.ReadLine());

            var selectedEvent = events.FirstOrDefault(e => e.Id == selectedEventId);

            if (selectedEvent == null)
                Console.WriteLine("Worng Id");

            if (!selectedEvent.Ticks.Any(t => t.Person == null))
                Console.WriteLine("No Tickets");

            var ticket = selectedEvent.Ticks.First(t => t.Person != null);
            ticket.Person = person;
            Console.WriteLine("Buy Secceesfully");

        }
    }

    public class Stad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
    }

    public class Even
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Stad Stadium { get; set; }
        public List<Tick> Ticks { get; set; }

        public Even(Stad stad)
        {
            Stadium = stad;
            FillTickets();

        }

        private void FillTickets()
        {
            Ticks = new List<Tick>(Stadium.Size);
            for (int i = 0; i < Stadium.Size; i++)
            {
                Tick tick = new Tick { Id = i, Price = 200.5 };
            }
        }
    }

    public class Tick
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public double Price { get; set; }
    }
}
