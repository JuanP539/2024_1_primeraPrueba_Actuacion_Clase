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
