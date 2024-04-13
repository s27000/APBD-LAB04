
namespace ProjektLAB04.Animals
{
    public class AnimalService : IAnimalService
    {
        private static List<Animal> AnimalList = new List<Animal>();
        public IEnumerable<Animal> GetAnimals()
        {
            return AnimalList;
        }

        public Animal GetAnimalById(int id)
        {
            foreach (Animal i in AnimalList)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }

        public IEnumerable<Animal> AddAnimal(Animal animal)
        {
            AnimalList.Add(animal);
            return AnimalList;
        }

        public Animal ModifyAnimal(int id, Animal modifiedAnimal)
        {
            Animal oldAnimal = GetAnimalById(id);
            oldAnimal.Id = modifiedAnimal.Id;
            oldAnimal.Name = modifiedAnimal.Name;
            oldAnimal.Type = modifiedAnimal.Type;
            oldAnimal.Mass = modifiedAnimal.Mass;
            oldAnimal.FurrColor = modifiedAnimal.FurrColor;
            return oldAnimal;
        }

        public IEnumerable<Animal> RemoveAnimal(int id)
        {
            AnimalList.Remove(GetAnimalById(id));
            return AnimalList;
        }
    }
}
