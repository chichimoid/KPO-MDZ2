using Zoo2.Domain;
using Zoo2.Domain.VO.Feeding;
using Zoo2.Infrastructure;

namespace Zoo2.Application.FeedingOrganizationService;

public class FeedingOrganizationService : IFeedingOrganizationService
{
    private IFeedingScheduleRepository _feedingScheduleRepository;

    public FeedingOrganizationService(FeedingScheduleRepository feedingScheduleRepository)
    {
        _feedingScheduleRepository = feedingScheduleRepository;
    }
    
    public FeedingOrganization Create(FeedingSchedule schedule)
    {
        var feedingOrganization = new FeedingOrganization(schedule);
        schedule.FeedingTimeEvent += feedingOrganization.Feed;
        return feedingOrganization;
    }

    public FeedingSchedule? GetSchedule(Animal animal)
    {
        return _feedingScheduleRepository.GetFeedingSchedule(animal);
    }
}