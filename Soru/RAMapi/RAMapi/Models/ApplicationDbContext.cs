using Microsoft.EntityFrameworkCore;

namespace RAMapi.Models
{
    public partial class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Character> Characters { get; set; }

       
    }
}
