using EFConnectDBDemo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConnectDBDemo
{
    public class DataBaseContext : DbContext
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        });
        public DbSet<Product> products { get; set; }

        public DbSet<Customer> customers { get; set; }

        private const string connectionString = @"Addr=HUD-HAIH;Database=ef_demo;Integrated Security=True;Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .UseSqlServer(connectionString);
        }
        
    }
}
