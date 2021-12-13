using System;
using System.Collections.Generic;

namespace Afisha.Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
