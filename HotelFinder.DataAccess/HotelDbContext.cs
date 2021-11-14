using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("Server=localhost/SQLEXPRESS;Database=HotelDb;Trusted_Connection=True;"); // copied, did not try
            //optionsBuilder.UseSqlServer("Data Source=localhost/SQLEXPRESS;Database=HotelDb;Integrated Security=True"); // error : do not use "/"
            //optionsBuilder.UseSqlServer("Data Source=localhost\SQLEXPRESS;Database=HotelDb;Integrated Security=True"); // error : use "\\" or "@"
            //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=HotelDb;Integrated Security=True"); // run : but did not do this way
            //optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Database=HotelDb;Integrated Security=True"); // run : do this way, just define string

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Database=HotelDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
