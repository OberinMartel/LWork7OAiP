using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KassirRu
{
    class UserContext : DbContext
    {
        public UserContext() : base("KassirRuDB") { }
        public DbSet<User> Users { get; set; }

        public User FindUserWithEMail(string EMail)
        {
            foreach (User user in Users)
            {
                if (user.Email == EMail) return user;
            }
            return null;
        }
        public User FindUserWithID(int ID)
        {
            foreach (User user in Users)
            {
                if (user.Id == ID) return user;
            }
            return null;
        }
    }
}
