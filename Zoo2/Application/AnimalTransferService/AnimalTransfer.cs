using Zoo2.Domain;

namespace Zoo2.Application.AnimalTransferService;

public class AnimalTransfer(Animal animal, Enclosure oldEnclosure, Enclosure newEnclosure)
{
    public void MoveAnimal(Enclosure oldEnclosure, Enclosure newEnclosure)
    {
        // TBA: Repository / await logic
        
        oldEnclosure.RemoveInhabitant(animal);
        newEnclosure.AddInhabitant(animal);
    }
}