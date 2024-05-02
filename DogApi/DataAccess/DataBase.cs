using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataBase
    {
        private static DataBase instance;

        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                    instance.AddDog(
                        new Dog()
                        {
                            Id = 1,
                            Breed = "Caucasian Shepherd Dog",
                            Description = "The Caucasian Shepherd Dog is a large " +
                            "and powerful breed of dog from the Caucasus Mountains region. " +
                            "These dogs are large in size, with a thick double coat to " +
                            "protect them from the cold. They have a regal bearing, with a " +
                            "proud and confident demeanor. They are highly intelligent and " +
                            "loyal, making them excellent guard dogs. They are courageous " +
                            "and alert, with an instinct to protect their family and property." +
                            " They are highly trainable, but require firm and consistent training.",
                            Hypoalergenic = false
                        }
                    );
                    instance.AddDog(
                        new Dog()
                        {
                            Id = 2,
                            Breed = "Border Collie",
                            Description = "The Border Collie is a medium-sized breed of herding dog " +
                            "from the borders of England and Scotland. These dogs are medium in size," +
                            " with a thick double coat of fur to protect them from the cold. They have" +
                            " an energetic and intelligent demeanor, with an instinct for herding and" +
                            " working. They are highly trainable and obedient, but require firm and " +
                            "consistent training to be obedient. They are loyal and devoted to their " +
                            "family, with an independent nature that makes them well suited for " +
                            "herding and guard work.",
                            Hypoalergenic = false
                        }
                    );

                }
                return instance;
            }
        }

        private List<Dog> dogs;
        private List<User> users;

        private DataBase()
        {
            dogs = new List<Dog>();
            users = new List<User>();
        }

        public List<Dog> GetDogs()
        {
            return dogs;
        }

        public void AddDog(Dog dog)
        {
            dogs.Add(dog);
        }

        public void UpdateDog(Dog dog)
        {
            var existingDog = dogs.Find(d => d.Id == dog.Id);
            if (existingDog != null)
            {
                existingDog.Breed = dog.Breed;
                existingDog.Description = dog.Description;
                existingDog.Hypoalergenic = dog.Hypoalergenic;
            }
        }

        public void DeleteDog(int id)
        {
            var dogToRemove = dogs.Find(d => d.Id == id);
            if (dogToRemove != null)
            {
                dogs.Remove(dogToRemove);
            }
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = users.Find(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Token = user.Token;
            }
        }

        public void DeleteUser(int id)
        {
            var userToRemove = users.Find(u => u.Id == id);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
        }
    }


}
