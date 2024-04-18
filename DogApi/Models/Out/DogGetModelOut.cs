using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Out
{
    public class DogGetModelOut
    {
        public string Breed { get; set; }
        public string Description { get; set; }
        public bool Hypoalergenic { get; set; }

        public DogGetModelOut() { }

        public DogGetModelOut(Dog dog) 
        {
            Breed = dog.Breed;
            Description = dog.Description;
            Hypoalergenic = dog.Hypoalergenic;
        }

        public override bool Equals(object? obj)
        {
            return obj is DogGetModelOut @out &&
                   Breed == @out.Breed &&
                   Description == @out.Description &&
                   Hypoalergenic == @out.Hypoalergenic;
        }
    }
}
