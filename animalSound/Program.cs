using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat("Cat"),
                new Dog("Dog"),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Type} makes sound: {animal.MakeSound()}");
            }
        }
    }
}
