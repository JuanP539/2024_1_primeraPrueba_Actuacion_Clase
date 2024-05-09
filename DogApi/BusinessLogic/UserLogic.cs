using Domain;
using IBusinessLogic;
using IBusinessLogic.Exceptions;
using IDataAccess;
using IDataAccess.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;
        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByToken(Guid userToken)
        {
            return _userRepository.FindByToken(userToken);
        }

        public Guid GetUserToken(string email, string password)
        {
            return _userRepository.GetUserToken(email, password);
        }

        public bool IsTheCorrectUser(Guid userToken)
        {
            return _userRepository.ExistUserByToken(userToken);
        }
    }
}
