namespace Zoo2.Domain.VO.Animal;

public enum FeedingType
{
    Carnivore,
    Herbivore
}

public enum SpeciesType
{
    Boar,
    Bear,
    Deer
}

public struct Species
{
    public FeedingType FeedingType { get; private set; }
    public SpeciesType SpeciesType { get; private set; }

    public Species(FeedingType feedingType, SpeciesType speciesType)
    {
        FeedingType = feedingType;
        SpeciesType = speciesType;
    }
}