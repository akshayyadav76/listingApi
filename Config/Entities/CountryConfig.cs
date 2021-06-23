
using listingApi.data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.Configurations.Entities
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    countryId = 5,
                    Name = "Bhopal",
                    ShortName = "BU"
                },
                new Country
                {
                    countryId = 6,
                    Name = "Indore",
                    ShortName = "IN"
                }, new Country
                {
                    countryId = 7,
                    Name = "Jabalpur mp",
                    ShortName = "JA"
                }
            );
        }
    }
}