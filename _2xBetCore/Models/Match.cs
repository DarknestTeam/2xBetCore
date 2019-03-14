using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Models
{
    public class Match
    {
        public int MatchId { get; set; }
        public bool IsAlive { get; set; }
        public string TypeOfSport { get; set; }
        public DateTime Time { get; set; }
        public string League { get; set; }
    }
}
