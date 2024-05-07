using Domain;
using IBusinessLogic;
using IDataAccess;
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
            throw new NotImplementedException();
        }

        public Dog CreateDog(Dog newDog)
        {
            throw new NotImplementedException();
        }
    }
}
