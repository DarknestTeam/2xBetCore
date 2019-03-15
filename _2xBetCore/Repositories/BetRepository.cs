using _2xBetCore.Data;
using _2xBetCore.Interfaces;
using _2xBetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Repositories
{
    public class BetRepository : AbstractRepository<Bet>, IBetGeneretic
    {
        private readonly DataContext context;
        public BetRepository(DataContext context) : base(context) { this.context = context; }

        public void Delete(int id)
        {
            var bet = Get(id);
            if (bet != null)
                context.Bets.Remove(bet);
        }

        public bool Exists(int id)
        {
            if (context.Bets.Any(b => b.BetId == id))
                return true;

            return false;
        }

      
        public Bet Get(int id)
        {
            var bet = context.Bets.FirstOrDefault(b => b.BetId == id);
            return bet;
        }
    }
}
