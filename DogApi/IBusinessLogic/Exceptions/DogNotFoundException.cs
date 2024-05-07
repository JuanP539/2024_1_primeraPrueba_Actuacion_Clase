using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogic.Exceptions
{
    public class DogNotFoundException : Exception
    {
        public DogNotFoundException() : base("Dog breed not found") { }
    }
}
