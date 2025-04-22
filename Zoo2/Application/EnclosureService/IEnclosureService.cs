using Zoo2.Domain;
using Zoo2.Domain.VO.Enclosure;

namespace Zoo2.Application.EnclosureService;

public interface IEnclosureService
{
    public Enclosure Create(EnclosureType enclosureType, EnclosureSize size, int capacity);

    public void Delete(Enclosure enclosure);
}