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
            dog.Drive(5);
            Console.ReadKey();

            AnimalsList.Instance.Show();
            AnimalsList.Instance.Show();
            Console.ReadKey();

            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";
 
            Console.WriteLine("{1} @ Zoo Special Offer and price are : {0} ", offer.Price, offer.Offer);
            Console.ReadKey();
        }
    }
}
