using CoreModel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Dersler> Derslers { get; set; }
        public DbSet<Ogretmenler> Ogretmenlers { get; set; }
        public DbSet<Ogrenciler> Ogrencilers { get; set; }
    }
}
