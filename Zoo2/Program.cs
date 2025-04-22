using Zoo2.Application.AnimalService;
using Zoo2.Application.AnimalTransferService;
using Zoo2.Application.EnclosureService;
using Zoo2.Application.FeedingOrganizationService;
using Zoo2.Application.FeedingScheduleService;
using Zoo2.Application.ZooStatisticsService;
using Zoo2.Domain.VO.Animal;
using Zoo2.Domain.VO.Enclosure;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;
using Zoo2.Infrastructure;
using Zoo2.Presentation;

namespace Zoo2;

class Program
{
    private static void Main()
    {
        var animalRepository = new AnimalRepository();
        var enclosureRepository = new EnclosureRepository();
        var feedingScheduleRepository = new FeedingScheduleRepository();
        
        var animalService = new AnimalService(animalRepository, enclosureRepository);
        var enclosureService = new EnclosureService(enclosureRepository);
        var animalTransferService = new AnimalTransferService();
        var feedingOrganizationService = new FeedingOrganizationService(feedingScheduleRepository);
        var feedingScheduleService = new FeedingScheduleService(feedingScheduleRepository, enclosureRepository);
        var zooStatisticsService = new ZooStatisticsService();
        
        var animalContoller = new AnimalController(animalService, animalTransferService, feedingOrganizationService, feedingScheduleService, zooStatisticsService);
        var enclosureController = new EnclosureController(enclosureService, animalTransferService);
        
        
        var carnivore1 = enclosureController.Create(EnclosureType.CarnivoreCage, new TwoDimensionalSize(3, 3), 4);
        var carnivore2 = enclosureController.Create(EnclosureType.CarnivoreCage, new TwoDimensionalSize(1, 1), 1);
        enclosureController.Delete(carnivore1);
        
        var bear = animalContoller.Create(carnivore1, new Species(FeedingType.Carnivore, SpeciesType.Bear), "Kopatych",
            new Date(2008, 1, 3),  Gender.Male, Food.Flesh, new HealthStatus(true));
        var feedings = new List<Feeding>()
        {
            new (Food.Flesh, 3.5f, new Time(13, 30)), 
            new (Food.Watermelon, 11f, new Time(16, 00)) 
        };
        animalContoller.AssignSchedule(bear, feedings);
        
        var herbivore = enclosureController.Create(EnclosureType.BirdCage, new ThreeDimensionalSize(1, 1, 1), 2);
        
        animalContoller.Move(bear, carnivore2, herbivore);
        animalContoller.ViewFeedingSchedule(bear);
        animalContoller.ViewTotalAnimals();
    }
}