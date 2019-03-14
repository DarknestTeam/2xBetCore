using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Data
{
    public interface IRepository
    {

        void Delete(string username);
        bool Exists(string username);


    }
}
