using Domain;
using IBusinessLogic;
using IBusinessLogic.Exceptions;
using IDataAccess;
using IDataAccess.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DogLogic : IDogLogic
    {
        private IDogRepository _dogRepo;
        public DogLogic(IDogRepository dogRepo) 
        {
            _dogRepo = dogRepo;
        }

        public Dog GetByBreed(Dog dog)
        {
            Dog ret;
            try
            {
                ret = _dogRepo.GetByBreed(dog.Breed);
            }
            catch (DataNotFoundException)
            {
                throw new DogNotFoundException();
            }   
            return ret;
        }

        public Dog CreateDog(Dog newDog)
        {
            Dog ret;
            try
            {
                ret = _dogRepo.Create(newDog);
            }
            catch (DataNotFoundException)
            {
                throw new AlreadyExistingDogException();
            }
            return ret;
        }
    }
}
