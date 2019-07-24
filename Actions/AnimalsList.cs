using System;
using System.Collections.Generic;
using ZooProject.Zoo;

namespace ZooProject.Actions
{
    public class AnimalsList
    {
        private List<Animal> animals;

        public AnimalsList()
        {
            animals = new List<Animal>();

            InitAnimals();
        }

        private void InitAnimals()
        {
            Duck donald = new Duck("Donald");
            Cat lizy = new Cat("Lizy");
            Dog rex = new Dog("Rex");
            Horse blackbeauty = new Horse("BlackBeauty");
            Turkey freebie = new Turkey("Freebie");
            Lion simba = new Lion("Simba");
            Zebra sam = new Zebra("Sam");
            Monkey cip = new Monkey("Cip");
            Elephant dumbo = new Elephant("Dumbo");
            Leopard jack = new Leopard("Jack");
            Eagle aras = new Eagle("Aras");

            animals.Add(donald);
            animals.Add(lizy);
            animals.Add(rex);
            animals.Add(blackbeauty);
            animals.Add(freebie);
            animals.Add(simba);
            animals.Add(sam);
            animals.Add(cip);
            animals.Add(dumbo);
            animals.Add(jack);
            animals.Add(aras);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.Name} makes {animal.MakeSound()}!");
            }
        }
    }
}