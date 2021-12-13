using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public uint Price { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
