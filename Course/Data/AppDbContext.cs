using Course.Entity;
using Microsoft.EntityFrameworkCore;

namespace Course.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Learning> Courses  { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

    }
}
