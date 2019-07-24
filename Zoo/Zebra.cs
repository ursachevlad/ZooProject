using System;

namespace ZooProject.Zoo
{
    public class Zebra : Animal
    {
        private const string SOUND = "BRRRRRR";

        public Zebra(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}