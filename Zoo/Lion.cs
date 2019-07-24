using System;

namespace ZooProject.Zoo
{
    public class Lion : Animal
    {
        private const string SOUND = "WOWWW";

        public Lion(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}