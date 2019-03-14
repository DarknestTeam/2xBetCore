//using _2xBetCore.Data;
//using _2xBetCore.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace _2xBetCore.Repositories
//{
//    public class MatchRepository : AbstractRepository<Match>, IRepository<Match>
//    {
//        private readonly DataContext context;

//        public MatchRepository(DataContext context):base(context) { this.context = context; }

//        public void Delete(int id)
//        {
//            var match = Get(id);
//            if (match != null)
//                context.Matches.Remove(match);
//        }

//        public bool Exists(int id)
//        {
//            if (context.Matches.Any(m => m.MatchId == id))
//                return true;

//            return false;
//        }

//        public Match Get(int id)
//        {
//            var match = context.Matches.FirstOrDefault(m => m.MatchId == id);
//            return match;
//        }
//    }
//}
