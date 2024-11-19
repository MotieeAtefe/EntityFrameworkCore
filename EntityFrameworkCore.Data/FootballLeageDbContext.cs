using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext: DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Intital Catalog=FootballLeage_EfCore; Encrypt=False;");
            optionsBuilder.UseNpgsql("Host=DESKTOP-8QOGGKP;Database=posgress;Username=postgres;Password=1377;");
            // optionsBuilder.UseNpgsql("Host=localhost;Database=your_database_name;Username=your_username;Password=your_password;");
        }
    }
}
