using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Data
{
    public class AbstractRepository<T> : IAbstractRepository<T> where T : class, new()
    {
       public DataContext _context;

        public AbstractRepository(DataContext context)
        {
            _context = context;
        }
        public T Create(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
            return item;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }
       

    }
}
