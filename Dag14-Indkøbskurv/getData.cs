using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class GetData
    {
        public Array Events { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string Location { get; set; }
        public Array Tickets { get; set; }
        public string TicketType { get; set; }
        public int TicketPrice { get; set;}
        public int TicketQuantity { get; set;}


        public Array Merchandise { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public int ItemPrice { get; set;}
        public Array ItemSizes { get; set; }
        public Array ItemColors { get; set; }
        public string ItemImageUrl { get; set; }


    }
}
