using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Models;

namespace MyBlazorApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .Property(t => t.FineAmount)
                .HasPrecision(18, 2);
        }
    }
}