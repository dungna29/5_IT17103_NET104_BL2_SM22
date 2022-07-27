using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFCORE_CODEFIRST_FLUENT_API.Context
{
    public class FPOLYDBContextFactory : IDesignTimeDbContextFactory<POLYDbContext>
    {
        public POLYDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("FPTPOLYCHSARP5DUNGNA");
            var optionBuilder = new DbContextOptionsBuilder<POLYDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new POLYDbContext(optionBuilder.Options);
        }
    }
}