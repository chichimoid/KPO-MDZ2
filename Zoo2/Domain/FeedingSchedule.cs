using Zoo2.Domain.VO.Feeding;

namespace Zoo2.Domain;

public class FeedingSchedule
{
    public Animal Animal { get; }
    public List<Feeding> Feedings { get; private set; }

    public FeedingSchedule(Animal animal, List<Feeding> feedings)
    {
        Animal = animal;
        Feedings = feedings;
    }

    public void Change(List<Feeding> newFeedings)
    {
        Feedings = newFeedings;
    }

    public void AddFeeding(Feeding feeding)
    {
        Feedings.Add(feeding);
    }

    public void RemoveFeeding(Feeding feeding)
    {
        Feedings.Remove(feeding);
    }

    public void RequestFeeding(Feeding feeding)
    {
        FeedingTimeEvent?.Invoke(feeding);
    }
    
    public delegate void FeedingTimeEventDelegate(Feeding feeding);
    public event FeedingTimeEventDelegate? FeedingTimeEvent;
}