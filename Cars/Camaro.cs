using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Cars
{
    using System;

    internal class Camaro : ICar
    {
        private readonly bool _isGasTankFull;
        public Camaro(bool isGasTankFull)
        {
            this._isGasTankFull = isGasTankFull;
        }

        public void StartEngine()
        {
            Console.WriteLine("The LS engine in the Camaro roars to life!");
        }

        public void StopEngine()
        {
            Console.WriteLine("The LS engine in the Camaro shuts down!");
        }

        public void Drive(Direction direction, int speed)
        {
            Console.WriteLine($"Camaro drives {direction} bound at {speed} mph");
        }
    }
}
