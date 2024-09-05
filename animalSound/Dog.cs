using System;

namespace AnimalSounds
{
    class Dog : Animal
    {
        public Dog(string type) : base(type) { }

        public override string MakeSound()
        {
            return "Woof";
        }
    }
}
