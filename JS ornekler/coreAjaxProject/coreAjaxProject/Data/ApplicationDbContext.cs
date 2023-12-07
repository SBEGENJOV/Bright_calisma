using coreAjaxProject.Models;
using coreAjaxProject.Models.Account;
using Microsoft.EntityFrameworkCore;

namespace coreAjaxProject.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<employe>Employes { get; set; }
        public DbSet<User>Users { get; set; }
    }
}
