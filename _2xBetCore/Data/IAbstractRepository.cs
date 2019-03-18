using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Data
{
 public   interface IAbstractRepository<T> where T: class
    {
        IQueryable<T> GetAll();
      
        T Create(T item);
       
        void Update(T item);

    
    }
}
