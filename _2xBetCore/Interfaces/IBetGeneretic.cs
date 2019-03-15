using _2xBetCore.Data;
using _2xBetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Interfaces
{
    interface IBetGeneretic:IAbstractRepository<Bet>
    {
        Bet Get(int id);
    }
}
