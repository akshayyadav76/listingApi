using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.data
{
    public class DatabaseContaxt : DbContext
    {

        public DatabaseContaxt(DbContextOptions options) :base(options) { 
        
        }

        public DbSet<Country> Contries { get; set; }
        public DbSet<Hotel> hotels { get; set; }
    }
}
