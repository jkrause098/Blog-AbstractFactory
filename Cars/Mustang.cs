using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Cars
{
    internal class Mustang : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("The 5.0L engine in the Mustang roars to life!");
        }

        public void StopEngine()
        {
            Console.WriteLine("The 5.0L engine in the Mustang shuts down!");
        }

        public void Drive(Direction direction, int speed)
        {
            Console.WriteLine($"Mustang drives {direction} bound at {speed} mph");
        }
    }
}
