using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string NumberCard { get; set; }
        public string Term { get; set; }
        public string CardHolderName { get; set; }
        public int Code { get; set; }
    }
}
