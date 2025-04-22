using Zoo2.Domain;

namespace Zoo2.Infrastructure;

public interface IEnclosureRepository
{
    public void Add(Enclosure enclosure);

    public void Remove(Enclosure enclosure);

    public Enclosure? Get(Enclosure enclosure);
}