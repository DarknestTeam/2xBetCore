using _2xBetCore.Data;
using _2xBetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Interfaces
{
    interface ICardGeneretic:IAbstractRepository<Card>
    {
        Card Get(string numbercard);
    }
}
