using Microsoft.EntityFrameworkCore;

namespace GetDataApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Network>().HasNoKey();
        }

        public DbSet<Network> Networks { get; set; }
    }
}
