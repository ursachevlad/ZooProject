namespace ZooProject.Zoo
{
    public class Cat : Animal
    {
        private const string SOUND = "MEOW";

        public Cat(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}