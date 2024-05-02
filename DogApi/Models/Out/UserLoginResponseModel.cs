using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Out
{
    public class UserLoginResponseModel
    {
        public Guid Token { get; set; }
        public UserLoginResponseModel(Guid userToken)
        {
            Token = userToken;
        }
    }
}
