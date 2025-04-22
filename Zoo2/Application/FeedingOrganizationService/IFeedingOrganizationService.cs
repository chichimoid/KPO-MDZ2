using Zoo2.Domain;

namespace Zoo2.Application.FeedingOrganizationService;

public interface IFeedingOrganizationService
{
    FeedingOrganization Create(FeedingSchedule schedule);
    FeedingSchedule? GetSchedule(Animal animal);
}