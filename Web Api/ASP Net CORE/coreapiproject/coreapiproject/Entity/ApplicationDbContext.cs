using Microsoft.EntityFrameworkCore;

namespace coreapiproject.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Sporcular> Sporculars { get; set; }
        public DbSet<Takimlar> Takimlars { get; set; }
    }
}

