using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogic.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("Email or password not found") { }
    }
}
