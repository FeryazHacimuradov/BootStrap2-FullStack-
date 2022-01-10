using Microsoft.EntityFrameworkCore;
using StartBootStrap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap2.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
