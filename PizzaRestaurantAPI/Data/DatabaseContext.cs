using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
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
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
        }
        public class PizzaConfiguration : IEntityTypeConfiguration<PizzaModel>
        {
            public void Configure(EntityTypeBuilder<PizzaModel> builder)
            {
                builder.Property(e => e.Ingredients).HasConversion(
    v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
    v => JsonConvert.DeserializeObject<IList<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            }
        }
    }
}
