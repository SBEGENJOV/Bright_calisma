using Microsoft.EntityFrameworkCore;
using odev_coreAjaxProject.Models;
using odev_coreAjaxProject.Models.Account;

namespace odev_coreAjaxProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Kutuphane> Kutuphanes { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
