using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.DB
{
    public class MySqlContext : DbContext
    {
        string connectionString = "Server=192.168.1.6;database=Test;user id=sa; password=De_05; TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Premises> Premises { get; set;}
        public DbSet<Tenants> Tenants { get; set;}
        public DbSet<LeaseAgreements> LeaseAgreements { get; set;}
        public DbSet<Payments> Payments { get; set;}
    }
}
