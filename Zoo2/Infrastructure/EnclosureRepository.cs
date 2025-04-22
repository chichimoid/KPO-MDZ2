using Zoo2.Domain;
using Zoo2.Domain.VO.Enclosure;

namespace Zoo2.Infrastructure;

public class EnclosureRepository : IEnclosureRepository
{
    public List<Enclosure> Enclosures { get; } = [];
    
    public void Add(Enclosure enclosure)
    {
        Enclosures.Add(enclosure);
    }

    public void Remove(Enclosure enclosure)
    {
        Enclosures.Remove(enclosure);
    }

    public Enclosure? Get(Enclosure enclosure)
    {
        return Enclosures.Find(e => e.Equals(enclosure));
    }
}