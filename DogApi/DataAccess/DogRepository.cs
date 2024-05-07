using Domain;
using IDataAccess;
using IDataAccess.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DogRepository : IDogRepository
    {
        public Dog GetByBreed(string breed)
        {
            List<Dog> dogs = DataBase.Instance.GetDogs();
            Dog ret = null;
            foreach (Dog dog in dogs) 
            {
                if (dog.Breed == breed) 
                {
                    ret = dog;
                }
            }
            if (ret == null) 
            {
                throw new DataNotFoundException();
            }
            return ret;
        }
        public Dog Create(Dog newDog)
        {
            List<Dog> dogs = DataBase.Instance.GetDogs();
            Dog ret = null;
            foreach (Dog dog in dogs)
            {
                if (dog.Breed == newDog.Breed)
                {
                    ret = dog;
                }
            }
            if (ret == null)
            {
                Dog dog = DataBase.Instance.AddDog(newDog);
                return dog;
            }else 
            {
                throw new DuplicateException();
            }
        }
    }
}
