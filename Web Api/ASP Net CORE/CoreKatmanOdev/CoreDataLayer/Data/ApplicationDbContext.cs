using CoreModelLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreDataLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

         public DbSet<Cocuk> Cocuks { get; set; }
         public DbSet<Personel> Personels { get; set; }
         public DbSet<Proje> Projes { get; set; }
         public DbSet<Gorev> Gorevs { get; set; }
         public DbSet<Unvan> Unvans { get; set; }
         public DbSet<Birimler> Birimlers { get; set; }
    } 
}
