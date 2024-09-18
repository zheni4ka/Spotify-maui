using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDB.Data
{
    public class SpotifyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SpotifyDb;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
