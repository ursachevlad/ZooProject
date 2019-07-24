namespace ZooProject.Zoo
{
    public class Turkey : Animal
    {
        private const string SOUND = "GOBB GOBB";

        public Turkey(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}