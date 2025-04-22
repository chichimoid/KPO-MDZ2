using Zoo2.Domain;
using Zoo2.Domain.VO.Feeding;

namespace Zoo2.Infrastructure;

public class FeedingScheduleRepository : IFeedingScheduleRepository
{
    public List<FeedingSchedule> FeedingSchedules { get; } = [];

    public FeedingSchedule? GetFeedingSchedule(Animal animal)
    {
        return FeedingSchedules.Find(fs => fs.Animal == animal);
    }

    public void Add(FeedingSchedule feedingSchedule)
    {
        FeedingSchedules.Add(feedingSchedule);
    }

    public void Remove(FeedingSchedule feedingSchedule)
    {
        FeedingSchedules.Remove(feedingSchedule);
    }
}