using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API_Car.Model;

namespace Web_API_Car.Models
{
    //This clase is responsible for connecting to the database and map models to tables
    public class Web_API_CarContext : DbContext
    {
        public Web_API_CarContext (DbContextOptions<Web_API_CarContext> options)
            : base(options)
        {
        }

        public DbSet<Web_API_Car.Model.Car> Car { get; set; }
    }
}
