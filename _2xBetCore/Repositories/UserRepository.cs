using _2xBetCore.Data;
using _2xBetCore.Interfaces;
using _2xBetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2xBetCore.Repositories
{
    public class UserRepository : AbstractRepository<User>,IUserGeneretic
    {
       public DataContext context;

        public UserRepository(DataContext context) : base(context) { this.context = context; }

        public void Delete(string username)
        {
            var user = Get(username);
            if (user != null)
                context.Users.Remove(user);
        }

        public bool Exists(string username)
        {
            if (context.Users.Any(u => u.Login == username))
                return true;

            return false;
        }
     public User Get(string username)
        {
            var user = context.Users.FirstOrDefault(u => u.Login == username);
            return user;
        }
        
    }
}
