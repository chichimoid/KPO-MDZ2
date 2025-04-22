using Zoo2.Domain.VO.Utility;

namespace Zoo2.Domain.VO.Feeding;

public struct Feeding
{
    public Food Food { get; set; }
    public float ServingSize { get; set; }
    public Time Time { get; set; }
    
    public Feeding(Food food, float servingSize, Time time)
    {
        Food = food;
        ServingSize = servingSize;
        Time = time;
    }
}