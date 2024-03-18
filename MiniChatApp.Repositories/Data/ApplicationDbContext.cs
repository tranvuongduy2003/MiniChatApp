using Microsoft.EntityFrameworkCore;
using MiniChatApp.Repositories.Data.Entities;

namespace MiniChatApp.Repositories.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R6DEQQ4;Database=MiniChatAppDB;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        }

        public DbSet<User> Users { set; get; }
    }
}
