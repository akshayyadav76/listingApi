using listingApi.Config.Entities;
using listingApi.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.data
{
    public class DatabaseContaxt : IdentityDbContext<ApiUser>
    {

        public DatabaseContaxt(DbContextOptions options) :base(options) { 
        
        }

        public DbSet<Country> Contries { get; set; }
        public DbSet<Hotel> hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfig());
            builder.ApplyConfiguration(new HotelConfig());
            builder.ApplyConfiguration(new CountryConfig());
            builder.Entity<Country>().HasData(
                new Country { 
                  countryId =1,
                  Name = "bhopal",
                  ShortName ="bu"
                   },
                new Country
                {
                    countryId = 2,
                    Name = "indore",
                    ShortName = "in"
                }, new Country
                {
                    countryId = 3,
                    Name = "jabalpur mp",
                    ShortName = "ja"
                }, new Country
                {
                    countryId = 4,
                    Name = "delhi",
                    ShortName = "da"
                }

                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    CountryId =1,
                    Address ="mp nager",
                    Rating =3.5,
                    Id =1,
                    Name = "hotel 1",
                   
                },
                new Hotel
                {
                    CountryId = 2,
                    Address = "jp nager",
                    Rating = 3.2,
                    Name = "hotel 2",
                    Id =2,

                },
                 new Hotel
                 {
                     Id = 3,
                     CountryId = 3,
                     Address = "kp nager",
                     Rating = 4.5,
                     Name = "hotel 3",

                 }
                );

        }
    }
}
