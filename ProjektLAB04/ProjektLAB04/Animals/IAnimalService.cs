namespace ProjektLAB04.Animals
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals();

        Animal GetAnimalById(int id);
        IEnumerable<Animal> AddAnimal(Animal animal);

        Animal ModifyAnimal(int id, Animal modifiedAnimal);

        IEnumerable<Animal> RemoveAnimal(int id);
    }
}
