using crudRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace crudRepo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
      public DbSet<Person> persons { get; set; }
    }
}
