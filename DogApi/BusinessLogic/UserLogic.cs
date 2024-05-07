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
            try
            {
                return _userRepository.FindByToken(userToken);
            }
            catch (DataNotFoundException)
            {
                throw new UserNotFoundException();
            }
        }

        public Guid GetUserToken(string email, string password)
        {
            Guid ret;

            try
            {
                ret = _userRepository.GetUserToken(email, password);
            }
            catch (DataNotFoundException)
            {
                throw new UserNotFoundException();
            }
            return ret;
        }

        public bool IsTheCorrectUser(Guid userToken)
        {
            try
            {
                return _userRepository.ExistUserByToken(userToken);
            }
            catch (DataNotFoundException)
            {
                throw new UserNotFoundException();
            }
        }
    }
}
