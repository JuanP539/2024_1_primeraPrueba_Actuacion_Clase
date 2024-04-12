using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLogic
{
    public interface IDogLogic
    {
        public Dog GetByName(Dog dog);
        public Dog CreateDog(Dog newDog);
    }
}
