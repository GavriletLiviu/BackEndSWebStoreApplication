using Services.Entities;
using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class UsersService
    {
        private List<User> _users;
        public UsersService()
        {
            _users = new List<User>()
            {
                new User
                {
                    UserName = "Gavrilet",
                    Password = "password",
                }
            };
        }
        public List<User> GetUsers()
        {
            return _users;
        }

        public User RetrieveUser(string username)
        {
            foreach (User c in _users)
            {
                if (c.UserName == username)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
