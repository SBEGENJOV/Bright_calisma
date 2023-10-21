using Microsoft.EntityFrameworkCore;

namespace Core_Join.Models
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Eleman> Elemens { get; set; }

    }
}
