using Zoo2.Application.AnimalTransferService;
using Zoo2.Application.EnclosureService;
using Zoo2.Domain;
using Zoo2.Domain.VO.Enclosure;

namespace Zoo2.Presentation;

public class EnclosureController
{
    private IEnclosureService _enclosureService;
    private IAnimalTransferService _animalTransferService;

    public EnclosureController(IEnclosureService enclosureService, IAnimalTransferService animalTransferService)
    {
        _enclosureService = enclosureService;
        _animalTransferService = animalTransferService;
    }
    
    public Enclosure Create(EnclosureType type, EnclosureSize size, int capacity)
    {
        var enclosure = _enclosureService.Create(type, size, capacity);
        Console.WriteLine($"Created enclosure {type}");
        return enclosure;
    }
    
    public void Delete(Enclosure enclosure)
    {
        _enclosureService.Delete(enclosure);
        Console.WriteLine($"Deleted enclosure {enclosure.Type}");
    }

    public void Move(Animal animal, Enclosure oldEnclosure, Enclosure newEnclosure)
    {
        animal.Move(oldEnclosure, newEnclosure);
        Console.WriteLine($"Moved animal {animal.Name}");
    }
}