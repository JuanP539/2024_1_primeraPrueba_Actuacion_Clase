using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess.Exceptions
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException() : base("Email or password not found") { }
    }
}
