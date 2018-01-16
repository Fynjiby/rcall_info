using Microsoft.EntityFrameworkCore;

namespace fpv_info.Models
{
    public class PartsContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public PartsContext(DbContextOptions<PartsContext> options)
            : base(options)
        {
        }
    }

}
