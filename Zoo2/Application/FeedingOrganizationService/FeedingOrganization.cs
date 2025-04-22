using Zoo2.Domain;
using Zoo2.Domain.VO.Feeding;

namespace Zoo2.Application.FeedingOrganizationService;

public class FeedingOrganization(FeedingSchedule schedule)
{
    public void Feed(Feeding feeding)
    {
        schedule.Animal.Feed(feeding.Food);
    }
}