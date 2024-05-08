using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.In
{
    public class DogCreateModelIn
    {
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Hypoalergenic { get; set; }

        public Dog ToEntity() 
        {
            return new Dog() 
            {
                Breed = this.Breed,
                Description = this.Description,
                Hypoalergenic = this.Hypoalergenic
            };
        }
    }
}
