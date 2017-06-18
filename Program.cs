namespace AbstractFactoryPattern
{
    using System;

    using AbstractFactoryPattern.Cars;
    using AbstractFactoryPattern.Interfaces;

    class Program
    {
        static void Main()
        {
            ICarFactory carfactory = new CarFactory();

            var camaro = carfactory.GetCar<Camaro>();
            camaro.StartEngine();
            camaro.Drive(Direction.North, 55);
            camaro.Drive(Direction.East, 45);
            camaro.StopEngine();

            Console.WriteLine("\r\n");

            var mustang = carfactory.GetCar<Mustang>();
            mustang.StartEngine();
            mustang.Drive(Direction.South, 65);
            mustang.Drive(Direction.West, 55);
            mustang.StopEngine();

            Console.WriteLine("\r\n");

            var charger = carfactory.GetCar<Charger>();
            charger.StartEngine();
            charger.Drive(Direction.East, 55);
            charger.Drive(Direction.North, 55);
            charger.StopEngine();

            Console.ReadKey();
        }
    }
}
