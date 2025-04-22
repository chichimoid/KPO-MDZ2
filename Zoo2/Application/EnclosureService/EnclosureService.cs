using Zoo2.Domain;
using Zoo2.Domain.VO.Enclosure;
using Zoo2.Infrastructure;

namespace Zoo2.Application.EnclosureService;

public class EnclosureService : IEnclosureService
{
    private IEnclosureRepository _enclosureRepository;
    
    public EnclosureService(IEnclosureRepository enclosureRepository)
    {
        _enclosureRepository = enclosureRepository;
    }
    
    public Enclosure Create(EnclosureType type, EnclosureSize size, int capacity) {
        var enclosure = new Enclosure(type, size, (uint)capacity);
        _enclosureRepository.Add(enclosure);
        
        return enclosure;
    }

    public void Delete(Enclosure enclosure)
    {
        _enclosureRepository.Remove(enclosure);
    }
}