namespace ZooProject.Zoo
{
    public class Duck : Animal
    {
        private const string SOUND = "MACMAC MAC";

        public Duck(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}