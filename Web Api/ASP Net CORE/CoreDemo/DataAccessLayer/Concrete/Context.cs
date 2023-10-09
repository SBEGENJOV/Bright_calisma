using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5K7HMBT\\SQLEXPRESS;database=CoreBlogDB; integrated security=true;");
        }
        public DbSet <About> Abouts{ get; set; }
        public DbSet <Blog> Blogs{ get; set; }
        public DbSet <Kategori> Kategoris{ get; set; }
        public DbSet <Comment> Comments{ get; set; }
        public DbSet <Contact> Contacts{ get; set; }
        public DbSet <Writer> Writers{ get; set; }
    }
}
