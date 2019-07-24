namespace ZooProject.Zoo
{
    public class Horse : Animal
    {
        private const string SOUND = "MMHAA MMBRR";

        public Horse(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}