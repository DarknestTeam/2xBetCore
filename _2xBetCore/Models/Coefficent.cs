using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Models
{
    // TODO: Проверить ситуацию с коэфицентами.Это коэфиценты если ставка прошла или ещё до.
    public class Coefficent
    {
        public int CoefficentId { get; set; }
        public double CoeffWin { get; set; }
        public double CoeffLose { get; set; }
        public double CoeffDraw { get; set; }
        public int MatchId { get; set; }
    }
}
