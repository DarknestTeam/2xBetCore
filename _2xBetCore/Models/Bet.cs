using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Models
{
    public class Bet
    {
        public int BetId { get; set; }
        public int MatchId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Choise { get; set; }
        public DateTime Time { get; set; }
        public string Result { get; set; }
    }
}
