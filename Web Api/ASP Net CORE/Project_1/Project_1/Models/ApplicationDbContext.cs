using Microsoft.EntityFrameworkCore;

namespace Project_1.Models
{
    public class ApplicationDbContext:DbContext
    {
        //veritabanına verileri gönderecegimiz alan.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {
            //bu bir constucterdir bu her cagrıldıgında veritabanına baglanması ve işlemlerin yapılmasını sağlar. Bu şekilde baglantıları yapabiliriz.
        }
        public DbSet<Diziler> Dizilers { get; set; }
        public DbSet<Oyuncular> Oyunculars { get; set; }
    }
}
