using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                    new City()
                    {
                        Id = 1,
                        Name = "New York City",
                        Description = "The onew ith a big park"
                    },
                     new City()
                     {
                         Id = 2,
                         Name = "Antwerp",
                         Description = "The one with the cathedral that was never finished"
                     },
                     new City()
                     {
                         Id = 3,
                         Name = "Paris",
                         Description = "The one with that big tower"
                     }
            );

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
