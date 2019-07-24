namespace ZooProject.Zoo
{
    public class Dog : Animal
    {
        private const string SOUND = "BARK BARK";

        public Dog(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}