using ZooProject.Actions;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsList zooAnimals = AnimalsList.Animals();
            animalsList.ShowAnimals();

            Animal animalsactivity = new ConcreteAnimal();
 
            IAnimalsActivity horse = animalsactivity.GetAnimal("Horse");
            Horse.Drive(10);
 
            IAnimalsActivity dog = animalsactivity.GetAnimal("Dog");
            dog.Drive(20);
 
            Console.ReadKey();
        }
    }
}
