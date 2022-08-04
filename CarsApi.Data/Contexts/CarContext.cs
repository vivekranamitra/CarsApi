using CarsApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarsApi.Data.Contexts
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = 1,
                    FullName = "John Smith",
                    UserName = "jsmith@cars.com",
                    Password = "abcdefgh"
                },
                new UserModel
                {
                    Id=2,
                    FullName = "Bob Andrews",
                    UserName = "bandrews@cars.com",
                    Password = "abcdefgh"
                }
            );

            modelBuilder.Entity<CarModel>().HasData(
                new CarModel
                {
                    Id = 1,
                    Make = "Ford",
                    Model = "Bronco"
                },
                new CarModel
                {
                    Id = 2,
                    Make = "Chevrolet",
                    Model = "Silverado"
                },
                new CarModel
                {
                    Id = 3,
                    Make = "Toyota",
                    Model = "RAV4"
                },

                new CarModel
                {
                    Id = 4,
                    Make = "Honda",
                    Model = "Pilot"
                },
                new CarModel
                {
                    Id = 5,
                    Make = "Mercedez",
                    Model = "Benz"
                }
            );
        }

        public virtual DbSet<CarModel> Cars { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
    }
}
