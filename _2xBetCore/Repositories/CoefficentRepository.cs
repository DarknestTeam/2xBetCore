using _2xBetCore.Data;
using _2xBetCore.Interfaces;
using _2xBetCore.Models;
using System;
using System.Linq;

namespace _2xBetCore.Repositories
{
    public class CoefficentRepository : AbstractRepository<Coefficent>, ICoefficentGeneretic
    {
        private readonly DataContext context;

        public CoefficentRepository(DataContext context) : base(context) { this.context = context; }

        public void Delete(int id)
        {
            var coefficent = Get(id);
            if (coefficent != null)
                context.Coefficents.Remove(coefficent);
        }

        public bool Exists(int id)
        {
            if (context.Coefficents.Any(c => c.CoefficentId == id))
                return true;

            return false;
        }

        public Coefficent Get(int id)
        {
            var coefficent = context.Coefficents.FirstOrDefault(c => c.CoefficentId == id);

            return coefficent;
        }
    }
}
