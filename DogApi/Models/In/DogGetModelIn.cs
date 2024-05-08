using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.In
{
    public class DogGetModelIn
    {
        public string Breed { get; set; }

        public Dog ToEntity()
        {
            return new Dog() 
            {
                Breed = this.Breed
            };
        }
    }
}
