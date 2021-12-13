using Afisha.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afisha.Persistence.EntityTypeConfigurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("events");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id).IsUnique();
            builder.HasIndex(e => e.Title).IsUnique();
            builder.Property(e => e.Description).HasColumnType("text");
            builder.Property(e => e.MaxCountTicket).HasColumnType("smallint");
            builder.Property(e => e.CountTicketSold).HasColumnType("smallint");
            //builder.Property(e => e.DateStart).HasColumnType("date");
            //builder.Property(e => e.DateEnd).HasColumnType("date");
            //builder.Property(e => e.TimeEvent).HasColumnType("time(0)");
        }
    }
}
