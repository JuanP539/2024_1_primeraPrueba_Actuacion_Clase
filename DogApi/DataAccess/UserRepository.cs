using Domain;
using IDataAccess;
using IDataAccess.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserRepository : IUserRepository
    {
        public bool ExistUserByToken(Guid userToken)
        {
            List<User> users = DataBase.Instance.GetUsers();
            User user = users[0];
            if (user.Token != userToken)
            {
                throw new DataNotFoundException();
            }
            return true;
        }

        public User FindByToken(Guid userToken)
        {
            List<User> users = DataBase.Instance.GetUsers();
            User user = users[0];
            if (user.Token != userToken)
            {
                throw new DataNotFoundException();
            }
            return users[0];
        }

        public Guid GetUserToken(string email, string password) 
        {
            List<User> users = DataBase.Instance.GetUsers();
            User user = users[0];
            if (user.Email!= email || user.Password != password)
            {
                throw new DataNotFoundException();
            }
            return users[0].Token;
        }
    }
}
