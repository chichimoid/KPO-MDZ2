using Zoo2.Domain;
using Zoo2.Domain.VO.Animal;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;

namespace Zoo2.Application.AnimalService;

public interface IAnimalService
{
    public Animal Create(Enclosure enclosure, Species species, 
        string name, Date birthDate, Gender gender, Food favouriteFood, HealthStatus status);

    public void Delete(Animal animal);
}