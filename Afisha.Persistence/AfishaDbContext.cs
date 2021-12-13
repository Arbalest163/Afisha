using Afisha.Application.Interfaces;
using Afisha.Domain;
using Afisha.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Persistence
{
    public class AfishaDbContext : DbContext, IAfishaDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public AfishaDbContext(DbContextOptions<AfishaDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new EventConfiguration());
            builder.ApplyConfiguration(new EventCategoryConfiguration());
            builder.ApplyConfiguration(new TicketConfiguration());
            base.OnModelCreating(builder);
        }
       
    }
}
