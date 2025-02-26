using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data;


namespace TicTacToe.Infrastructure
{
    public class TicTacToeDBContext:DbContext
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TicTacToeBase"].ConnectionString;
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            

            optionsBuilder.UseSqlite(connectionString);
        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<NonPlayable> NonPlayable { get; set; }

    }
    
}
