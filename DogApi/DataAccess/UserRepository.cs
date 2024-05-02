using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserRepository
    {
        public Guid GetUserToken() 
        {
            List<User> users = DataBase.Instance.GetUsers();
            return users[0].Token;
        }
    }
}
