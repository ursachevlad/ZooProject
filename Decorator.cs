using System;

public interface Animal
{
    string Make { get; }
    double Price { get; }
}

public class Horse : Animal
{
    public string Make
    {
        get { return "Horse"; }
    }

    public double Price
    {
        get { return 1000; }
    }
}

public abstract class AnimalDecorator : Animal
{
    private Animal _animal;

    public AnimalDecorator(Animal animal)
    {
        _animal = animal;
    }

    public string Make
    {
        get { return _animal.Make; }
    }

    public double Price
    {
        get { return _animal.Price; }
    }

}
