using Zoo2.Domain.VO.Enclosure;

namespace Zoo2.Domain;

public class Enclosure
{
    public EnclosureType Type { get; }
    public EnclosureSize Size { get; }

    public List<Animal> CurrentInhabitants { get; private set; } = [];
    public uint InhabitantsAmount => (uint)CurrentInhabitants.Count;
    public uint InhabitantsCapacity { get; }

    public Enclosure(EnclosureType type, EnclosureSize size, uint inhabitantsCapacity)
    {
        Type = type;
        Size = size;
        InhabitantsCapacity = inhabitantsCapacity;
    }

    public void AddInhabitant(Animal animal)
    {
        CurrentInhabitants.Add(animal);
    }

    public void RemoveInhabitant(Animal animal)
    {
        CurrentInhabitants.Remove(animal);
    }

    public void Clean()
    {
        // TBA: actual logic
    }
}