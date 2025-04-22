using Zoo2.Application.AnimalService;
using Zoo2.Application.AnimalTransferService;
using Zoo2.Application.FeedingOrganizationService;
using Zoo2.Application.FeedingScheduleService;
using Zoo2.Application.ZooStatisticsService;
using Zoo2.Domain;
using Zoo2.Domain.VO.Animal;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;

namespace Zoo2.Presentation;

public class AnimalController
{
    private IFeedingOrganizationService _feedingOrganizationService;
    private IFeedingScheduleService _feedingScheduleService;
    private IAnimalService _animalService;
    private IZooStatisticsService _zooStatisticsService;

    public AnimalController(IAnimalService animalService, IAnimalTransferService animalTransferService, IFeedingOrganizationService feedingOrganizationService, 
        IFeedingScheduleService feedingScheduleService, IZooStatisticsService zooStatisticsService)
    {
        _feedingOrganizationService = feedingOrganizationService;
        _animalService = animalService;
        _zooStatisticsService = zooStatisticsService;
        _feedingScheduleService = feedingScheduleService;
    }
    
    public Animal Create(Enclosure enclosure, Species species, string name, Date birthDate, Gender gender, Food favouriteFood,
        HealthStatus status)
    {
        var animal = _animalService.Create(enclosure, species, name, birthDate, gender, favouriteFood, status);
        Console.WriteLine($"Created animal {name}");
        return animal;
    }
    
    public void Delete(Animal animal)
    {
        _animalService.Delete(animal);
        Console.WriteLine($"Deleted animal {animal.Name}");
    }

    public void Move(Animal animal, Enclosure oldEnclosure, Enclosure newEnclosure)
    {
        animal.Move(oldEnclosure, newEnclosure);
        Console.WriteLine($"Moved animal {animal.Name}");
    }
    
    public void AssignSchedule(Animal animal, List<Feeding> feedings)
    {
        _feedingScheduleService.Create(animal, feedings);
    }

    public void ViewFeedingSchedule(Animal animal)
    {
        if (_feedingOrganizationService.GetSchedule(animal) == null) return;
        
        foreach (var feeding in _feedingOrganizationService.GetSchedule(animal).Feedings)
        {
            Console.WriteLine($"{feeding.ServingSize} {feeding.Food} at {feeding.Time}");
        }
        Console.WriteLine();
    }

    public void AddNewFeeding(Animal animal, Feeding feeding)
    {
        _feedingOrganizationService.GetSchedule(animal)?.AddFeeding(feeding);
    }

    public void ViewTotalAnimals()
    {
        Console.WriteLine($"Total animal amount: {_zooStatisticsService.GetTotalAnimalAmount()}");
    }
}