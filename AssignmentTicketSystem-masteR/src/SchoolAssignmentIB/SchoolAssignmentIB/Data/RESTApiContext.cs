using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace RESTApi.Models
{
    public class RESTApiContext : DbContext
    {

        public DbSet<Actor> Actor { get; set; }

        public static readonly LoggerFactory MovieLoggerFactory
            = new LoggerFactory(new[] {
            new ConsoleLoggerProvider((category, level)
                => category == DbLoggerCategory.Database.Command.Name &&
                 level == LogLevel.Information, true)
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(MovieLoggerFactory)
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = WebutvDB; Trusted_Connection = True;");
        }

    }
}
