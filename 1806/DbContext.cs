using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace YourNamespace.Data
{
    public class YourDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } // Dodaj DbSet<Product> tutaj
        public DbSet<Order> Orders { get; set; }

        public DbSet<Event> Events { get; set; }
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
        }

        // Możesz dodać dodatkowe DbSet<> dla innych modeli, jeśli są potrzebne
    }
}
