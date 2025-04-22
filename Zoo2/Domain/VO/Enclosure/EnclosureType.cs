namespace Zoo2.Domain.VO.Enclosure;

public enum EnclosureType
{
    CarnivoreCage,
    HerbivoreCage,
    BirdCage,
    FishTank,
    FreeRoam
}

public static class EnclosureTypeExtensions
{
    public static Type GetSizeDimensions(this EnclosureType enclosureType)
    {
        return enclosureType switch
        {
            EnclosureType.CarnivoreCage => typeof(TwoDimensionalSize),
            EnclosureType.HerbivoreCage => typeof(TwoDimensionalSize),
            EnclosureType.BirdCage => typeof(ThreeDimensionalSize),
            EnclosureType.FishTank => typeof(ThreeDimensionalSize),
            EnclosureType.FreeRoam => typeof(UnrestrictedSize),
            _ => typeof(UnrestrictedSize)
        };
    }
}