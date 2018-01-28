using Microsoft.EntityFrameworkCore;

namespace fpv_info.Models
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {
        }
    }

}
