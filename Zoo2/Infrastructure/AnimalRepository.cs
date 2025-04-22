using Zoo2.Domain;
using Zoo2.Domain.VO.Animal;

namespace Zoo2.Infrastructure;

public class AnimalRepository : IAnimalRepository
{
    public List<Animal> Animals { get; } = [];
    
    public void Add(Animal animal)
    {
        Animals.Add(animal);
    }

    public void Remove(Animal animal)
    {
        Animals.Remove(animal);
    }
}