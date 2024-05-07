using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogic.Exceptions
{
    public class AlreadyExistingDogException : Exception
    {
        public AlreadyExistingDogException() : base("Dog breed already exist") { }
    }
}
