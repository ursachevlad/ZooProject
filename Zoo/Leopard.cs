using System;

namespace ZooProject.Zoo
{
    public class Leopard : Animal
    {
        private const string SOUND = "MRRRRRRR";

        public Leopard(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}