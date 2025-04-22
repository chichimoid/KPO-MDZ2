using Zoo2.Domain;
using Zoo2.Domain.VO.Animal;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;
using Zoo2.Infrastructure;

namespace Zoo2.Application.AnimalService;

public class AnimalService : IAnimalService
{
    private IAnimalRepository _animalRepository;
    private IEnclosureRepository _enclosureRepository;
    
    public AnimalService(IAnimalRepository animalRepository, IEnclosureRepository enclosureRepository)
    {
        _animalRepository = animalRepository;
        _enclosureRepository = enclosureRepository;
    }
    
    public Animal Create(Enclosure enclosure, Species species, string name, Date birthDate, Gender gender, Food favouriteFood, 
        HealthStatus status) {
        
        var animal = new Animal(species, name, birthDate, gender, favouriteFood, status);
        _animalRepository.Add(animal);
        _enclosureRepository.Get(enclosure)?.AddInhabitant(animal);
        
        return animal;
    }

    public void Delete(Animal animal)
    {
        _animalRepository.Remove(animal);
    }
}