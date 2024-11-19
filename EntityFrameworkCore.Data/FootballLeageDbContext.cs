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
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Intital Catalog=FootballLeage_EfCore; Encrypt=False;");
        }
    }
}
