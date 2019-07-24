namespace ZooProject.Zoo
{
    public abstract class Animal : IMakeSound
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}