using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Event
    {
        public string eventName { get; set; }
        public string eventDate { get; set; }
        public string location { get; set; }
        public Ticket[] tickets
        {
            get; set;
        }
    }
}
