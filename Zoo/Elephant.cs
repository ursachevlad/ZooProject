using System;

namespace ZooProject.Zoo
{
    public class Elephant : Animal
    {
        private const string SOUND = "UUUUUUUA";

        public Elephant(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}