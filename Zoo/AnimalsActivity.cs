using System;

namespace AnimalsActivity
{
    public class Horse : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Horse activity in a day is : " + miles.ToString() + "km");
        }
    }

    public class Dog : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Dog activity in 24h is: " + miles.ToString() + "km");
        }
    }

    public abstract class Animal
    {
        public abstract IFactory GetAnimal(string Animal);
    }

    public class ConcreteAnimal : Animal
    {
        public override IFactory Animal(string Animal)
        {
            switch (Animal)
            {
                case "Horse":
                    return new Horse();
                case "Dog":
                    return new Dog();
                default:
                    throw new ApplicationException(string.Format("Animal '{0}' cannot be created", Animal));
            }
        }
    }
}
