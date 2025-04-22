using Zoo2.Domain;

namespace Zoo2.Application.AnimalTransferService;

public class AnimalTransferService : IAnimalTransferService
{
    public AnimalTransfer Create(Animal animal, Enclosure oldEnclosure, Enclosure newEnclosure)
    {
        var animalTranfer = new AnimalTransfer(animal, oldEnclosure, newEnclosure);
        animal.OnAnimalMoved += animalTranfer.MoveAnimal;
        
        return animalTranfer;
    }
}