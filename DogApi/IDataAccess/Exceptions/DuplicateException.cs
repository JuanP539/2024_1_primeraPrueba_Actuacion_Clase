using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess.Exceptions
{
    public class DuplicateException : Exception
    {
        public DuplicateException() : base("Dog breed already exist") { }
    }
}
