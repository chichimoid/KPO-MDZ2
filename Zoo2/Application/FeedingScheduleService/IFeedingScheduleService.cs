using Zoo2.Domain;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;

namespace Zoo2.Application.FeedingScheduleService;

public interface IFeedingScheduleService
{
    public FeedingSchedule Create(Animal animal, List<Feeding> feedings);

    public void Delete(FeedingSchedule feedingSchedule);
}