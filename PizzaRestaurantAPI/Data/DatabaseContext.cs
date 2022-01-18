using Microsoft.EntityFrameworkCore;
using PizzaRestaurantAPI.Models;

namespace PizzaRestaurantAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<PizzaModel>? Pizzas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaModel>(x =>
            x.HasKey(y=>y.Id)
            );
        }
    }
}
