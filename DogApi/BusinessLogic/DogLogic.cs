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
            return _dogRepo.GetByBreed(dog.Breed);
        }

        public Dog CreateDog(Dog newDog)
        {
            return _dogRepo.Create(newDog);
        }
    }
}
