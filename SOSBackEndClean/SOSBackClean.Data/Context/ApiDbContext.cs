using Microsoft.EntityFrameworkCore;
using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() 
        {
            
        }

        public DbSet<Funcionario> Funcionario {get; set;}
        public DbSet<Predio> Predio { get; set;}
        public DbSet<Formulario> Formulario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=TestDb;user=root;password=root123";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
        }

    }
}
