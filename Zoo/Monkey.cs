using System;

namespace ZooProject.Zoo
{
    public class Monkey : Animal
    {
        private const string SOUND = "UAHAAA";

        public Monkey(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}