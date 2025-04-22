using Zoo2.Domain.VO.Utility;
using Zoo2.Domain.VO.Animal;
using Zoo2.Domain.VO.Feeding;

namespace Zoo2.Domain;

public class Animal
{
    public Species Species { get; }
    public string Name { get; private set; }
    public Date BirthDate { get; }
    public Gender Gender { get; }
    public Food FavouriteFood { get; private set; }
    public HealthStatus Status { get; private set; }

    public Animal(Species species, string name, Date birthDate, Gender gender, Food favouriteFood, HealthStatus status)
    {
        Species = species;
        Name = name;
        BirthDate = birthDate;
        Gender = gender;
        FavouriteFood = favouriteFood;
        Status = status;
    }

    public void Feed(Food food)
    {
        Console.WriteLine($"Animal {Name} has been fed {food}.");
    }

    public void Treat()
    {
        Status = new HealthStatus(true);
    }

    public void Move(Enclosure oldEnclosure, Enclosure newEnclosure)
    {
        OnAnimalMoved?.Invoke(oldEnclosure, newEnclosure);
    }

    public delegate void OnAnimalMovedDelegate(Enclosure oldEnclosure, Enclosure newEnclosure);
    public event OnAnimalMovedDelegate? OnAnimalMoved;
}