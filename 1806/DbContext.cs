using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace YourNamespace.Data
{

    public class YourDbContext : DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Product { get; set; } // Dodaj DbSet<Product> tutaj
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Event> Event { get; set; }
        public DbSet<ItemShop> ItemShop { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemShop>()
                .Property(i => i.Price)
                .HasColumnType("numeric(12, 2)");
        }

        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
        }


        // Możesz dodać dodatkowe DbSet<> dla innych modeli, jeśli są potrzebne
    }
}
