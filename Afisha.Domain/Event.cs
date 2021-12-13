using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Domain
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeEvent { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public ICollection<EventCategory> Categories { get; set; }
        public string Description { get; set; }
        public byte AgeRestriction { get; set; }
        public ushort MaxCountTicket { get; set; }
        public ushort CountTicketSold { get; set; }
    }
}
