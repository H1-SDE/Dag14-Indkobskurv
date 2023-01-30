using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Program
    {

        public static int i = 1;
        public static int j = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                string output = Start();

                switch (output)
                {
                    case "1":
                        break;
                    case "2":
                        Event();
                        break;
                }
            }
        }

        static string Start()
        {
            Console.WriteLine("Chouse what you want to do:");
            Console.WriteLine("1: merchandise");
            Console.WriteLine("2: Events");
            return Console.ReadLine();
        }

        static void Event()
        {
            Events events = GetData.GetEvent();

            Console.WriteLine("Couse a event:");
            foreach (var ev in events.events)
            {
                Console.WriteLine($"{i}: {ev.eventName}");
                i++;
                Console.WriteLine("\tEvent Date: " + ev.eventDate);
                Console.WriteLine("\tLocation: " + ev.location);
                Console.WriteLine("\tTickets:");
                foreach (var t in ev.tickets)
                {
                    if (t.quantity > 0)
                    {
                        Console.WriteLine("\t\tTicket Type: " + t.ticketType);
                        Console.WriteLine("\t\tPrice: " + t.price);
                        Console.WriteLine("\t\tQuantity: " + t.quantity);
                    }


                }
            }

            Ticket(Console.ReadLine());
        }

        static void Ticket(string eventet)
        {
            Events events = GetData.GetEvent();

            Console.WriteLine("Couse a ticket:");
            foreach (var ev in events.events)
            {
                foreach (var t in ev.tickets)
                {
                    if (t.quantity > 0)
                    {
                        if (j.ToString() == eventet)
                        {
                            Console.WriteLine("\t\tTicket Type: " + t.ticketType);
                            Console.WriteLine("\t\tPrice: " + t.price);
                            Console.WriteLine("\t\tQuantity: " + t.quantity);
                        }
                    }
                }
                j++;
            }
        }

        public void SaveData (string type, string eventName?, string ) { }
    }
}
