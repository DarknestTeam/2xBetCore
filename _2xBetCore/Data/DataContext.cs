using _2xBetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options) { }


        public DbSet<Bet> Bets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Coefficent> Coefficents { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
