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
            List<Dog> dogs = DataBase.Instance.GetDogs();
            return dogs;
        }
        public Dog Create(Dog newDog)
        {
            Dog dog = DataBase.Instance.AddDog(newDog);
            return dog;
        }
    }
}
