using System;

namespace AnimalSounds
{
    // Definim o clasă abstractă Animal
    abstract class Animal
    {
        public string Type { get; }

        // Definim o metoda abstracta pentru sunet
        public abstract string MakeSound();

        public Animal(string type)
        {
            Type = type;
        }
    }
}