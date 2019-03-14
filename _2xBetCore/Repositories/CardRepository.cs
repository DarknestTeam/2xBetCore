//using _2xBetCore.Data;
//using _2xBetCore.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace _2xBetCore.Repositories
//{
//    public class CardRepository : AbstractRepository<Card>, IRepository<Card>
//    {
//        private readonly DataContext context;
//        public CardRepository(DataContext context) : base(context) { this.context = context; }

//        public void Delete(string number)
//        {
//            var card = Get(number);
//            if(card!=null)
//            context.Remove(card);
//        }

//        public bool Exists(string number)
//        {
//            if (context.Cards.Any(c => c.NumberCard == number))
//                return true;

//            return false;
//        }

//        public Card Get(string number)
//        {
//            var card = context.Cards.FirstOrDefault(c=>c.NumberCard == number);

//            return card;
//        }
//    }
//}
