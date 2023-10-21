using Ulke_Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Ulke_Core.Models
{
    public class ApplicationDbContext:DbContext
    {
        //veritabanına verileri gönderecegimiz alan.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {
            //bu bir constucterdir bu her cagrıldıgında veritabanına baglanması ve işlemlerin yapılmasını sağlar. Bu şekilde baglantıları yapabiliriz.
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
