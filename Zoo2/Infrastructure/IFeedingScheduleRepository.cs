using Zoo2.Domain;

namespace Zoo2.Infrastructure;

public interface IFeedingScheduleRepository
{
    public FeedingSchedule? GetFeedingSchedule(Animal animal);
    public void Add(FeedingSchedule feedingSchedule);

    public void Remove(FeedingSchedule feedingSchedule);
}