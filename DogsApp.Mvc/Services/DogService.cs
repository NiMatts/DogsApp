using System.Reflection;
using DogsApp.Mvc.Models;

namespace DogsApp.Mvc.Services
{
    public class DogService
    {
        private List<Dog> dogs = [
            new Dog { Id = 12, Name = "Fiddo", Age = 3},
            new Dog { Id = 12, Name = "Fiddo", Age = 5},
            new Dog { Id = 12, Name = "Fiddo", Age = 4},
            ];
        public Dog[] GetAllDogs()
        {
            return dogs.OrderBy(o => o.Name).ToArray();
        }

        public Dog GetDogById(int id)
        {
            return dogs.SingleOrDefault(o => o.Id == id);
        }
        public void AddDog(Dog dog)
        {
            dog.Id = dogs.Max(o => o.Id) + 1;
            dogs.Add(dog);
        }
    }
}
