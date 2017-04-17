using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppArbete_Personer.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GruppArbete_Personer
{
    public class MydbContextFactory : IDbContextFactory<PersonDbContext>
    {
        public PersonDbContext Create()
        {
            var environmentName =
                Environment.GetEnvironmentVariable(
                    "Hosting:Environment");

            var basePath = AppContext.BaseDirectory;

            return Create(basePath, environmentName);
        }

        public PersonDbContext Create(DbContextFactoryOptions options)
        {
            return Create(
                options.ContentRootPath,
                options.EnvironmentName);
        }

        private PersonDbContext Create(string basePath, string environmentName)
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            var connstr = config.GetConnectionString("(default)");

            if (String.IsNullOrWhiteSpace(connstr) == true)
            {
                throw new InvalidOperationException(
                    "Could not find a connection string named '(default)'.");
            }
            else
            {
                return Create(connstr);
            }
        }

        private PersonDbContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException(
                    $"{nameof(connectionString)} is null or empty.",
                    nameof(connectionString));

            var optionsBuilder =
                new DbContextOptionsBuilder<PersonDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new PersonDbContext(optionsBuilder.Options);
        }
    }
}
