using FurnaceCalculation.DAL.MSSQL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnaceCalculation.DAL.MSSQL.Context
{
    public class FurnaceCalculationContext : DbContext
    {
        public FurnaceCalculationContext(DbContextOptions<FurnaceCalculationContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<User> Users { get; set; } 
    }
}
