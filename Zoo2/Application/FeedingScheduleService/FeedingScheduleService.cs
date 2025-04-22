using Zoo2.Domain;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Domain.VO.Utility;
using Zoo2.Infrastructure;

namespace Zoo2.Application.FeedingScheduleService;

public class FeedingScheduleService : IFeedingScheduleService
{
    private IFeedingScheduleRepository _feedingScheduleRepository;
    private IEnclosureRepository _enclosureRepository;
    
    public FeedingScheduleService(IFeedingScheduleRepository feedingScheduleRepository, IEnclosureRepository enclosureRepository)
    {
        _feedingScheduleRepository = feedingScheduleRepository;
        _enclosureRepository = enclosureRepository;
    }
    
    public FeedingSchedule Create(Animal animal, List<Feeding> feedings) {
        var feedingSchedule = new FeedingSchedule(animal, feedings);
        _feedingScheduleRepository.Add(feedingSchedule);

        return feedingSchedule;
    }

    public void Delete(FeedingSchedule feedingSchedule)
    {
        _feedingScheduleRepository.Remove(feedingSchedule);
    }
}