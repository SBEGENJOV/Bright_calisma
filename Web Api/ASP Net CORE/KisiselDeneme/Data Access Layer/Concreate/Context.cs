using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concreate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5K7HMBT\\SQLEXPRESS;database=FutbolDB; integrated security=true;");
        }

       public DbSet<Lig1> Lig1s { get; set; }
       public DbSet<Takim1> Takim1s { get; set; }
       public DbSet<Oyuncu1> Oyuncu1s { get; set; }
    }
}
