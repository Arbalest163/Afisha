using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Afisha.Domain;

namespace Afisha.Application.Interfaces
{
    public interface IAfishaDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<EventCategory> EventCategories { get; set; }
        DbSet<Ticket> Tickets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
