using Zoo2.Domain;

namespace Zoo2.Infrastructure;

public interface IAnimalRepository
{
    public void Add(Animal animal);

    public void Remove(Animal animal);
}