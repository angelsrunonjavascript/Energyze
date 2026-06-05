using Microsoft.EntityFrameworkCore;
using WebsiteProject.Models;

namespace WebsiteProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EnergyDrink> EnergyDrinks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RecentView> RecentViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorite>()
                .HasIndex(f => new { f.UserId, f.EnergyDrinkId })
                .IsUnique();

            modelBuilder.Entity<Rating>()
                .HasIndex(r => new { r.UserId, r.EnergyDrinkId })
                .IsUnique();

            modelBuilder.Entity<RecentView>()
                .HasIndex(r => new { r.UserId, r.EnergyDrinkId })
                .IsUnique();
        }
    }
}
