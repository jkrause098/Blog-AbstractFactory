using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Cars
{
    internal class Charger : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("The HEMI engine in the Charger roars to life!");
        }

        public void StopEngine()
        {
            Console.WriteLine("The HEMI engine in the Charger shuts down!");
        }

        public void Drive(Direction direction, int speed)
        {
            Console.WriteLine($"Charger drives {direction} bound at {speed} mph");
        }
    }
}
