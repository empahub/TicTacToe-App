using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe.Infrastructure
{
    internal class TicTacToeDBContext:DbContext
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TicTacToeBase"].ConnectionString;
        public TicTacToeDBContext():base() 
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            

            optionsBuilder.UseSqlite(connectionString);
        }


    }
    
}
