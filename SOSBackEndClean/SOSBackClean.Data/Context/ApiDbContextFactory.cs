using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.Context
{
    public class ApiDbContextFactory
        : IDesignTimeDbContextFactory<ApiDbContext>
    {
        public ApiDbContext CreateDbContext(
            string[] args)
        {
            var connectionString =
                "server=localhost;database=TestDb;user=root;password=root123";

            var optionsBuilder =
                new DbContextOptionsBuilder<ApiDbContext>();

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString));

            return new ApiDbContext(
                optionsBuilder.Options);
        }
    }
}
