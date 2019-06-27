using Microsoft.EntityFrameworkCore;
using SellCarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellCarAPI.Data
{
    public class CarsContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarsContext(DbContextOptions options) : base(options)
        {

        }
    }
}
