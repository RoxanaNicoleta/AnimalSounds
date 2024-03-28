using System;

namespace AnimalSounds
{
    class Cat : Animal
    {
        public Cat(string type) : base(type) { }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
