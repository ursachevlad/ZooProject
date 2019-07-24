using System;

namespace ZooProject.Zoo
{
    public class Eagle : Animal
    {
        private const string SOUND = "KIKIKIKI";

        public Eagle(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}