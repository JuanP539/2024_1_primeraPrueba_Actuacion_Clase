using Domain;
using IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DogRepository : IDogRepository
    {
        public List<Dog> Get()
        {
            throw new NotImplementedException();
        }
        public Dog Create(Dog newDog)
        {
            throw new NotImplementedException();
        }
    }
}
