using Microsoft.EntityFrameworkCore;
using RentCarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarAPI.Data
{
    public class RentCarDataContext : DbContext
    {
        public RentCarDataContext(DbContextOptions<RentCarDataContext> options): base(options) { }
        
        public DbSet<Value> Values { get; set; } 
    }
}
