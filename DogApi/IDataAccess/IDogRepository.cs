using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccess
{
    public interface IDogRepository
    {
        public List<Dog> Get();
        public Dog Create(Dog newDog);
    }
}
