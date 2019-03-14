//using _2xBetCore.Data;
//using _2xBetCore.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace _2xBetCore.Repositories
//{
//    public class BetRepository : AbstractRepository<Bet>, IRepository<Bet>
//    {
//        private readonly DataContext context;
//        public BetRepository(DataContext context) : base(context) { this.context = context; }

//        public void Delete(string number)
//        {
//            var bet = Get(id);
//            if(bet!=null)
//            context.Bets.Remove(bet);
//        }

//        public bool Exists(int id)
//        {
//            if (context.Bets.Any(b => b.BetId == id))
//                return true;

//            return false;
//        }

//        public Bet Get(string betname)
//        {
//            var bet = context.Bets.FirstOrDefault(b => b.);
          
//                return bet;
//        }
//    }
//}
