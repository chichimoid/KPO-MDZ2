using Zoo2.Domain;

namespace Zoo2.Application.AnimalTransferService;

public interface IAnimalTransferService
{
    AnimalTransfer Create(Animal animal, Enclosure oldEnclosure, Enclosure newEnclosure);
}