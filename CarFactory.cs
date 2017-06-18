using System;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Cars;

namespace AbstractFactoryPattern
{
    internal class CarFactory : ICarFactory
    {
        T ICarFactory.GetCar<T>()
        {
            var car = typeof(T);

            switch (car.Name)
            {
                case "Camaro":
                    return new Camaro(true) as T;
                case "Mustang":
                    return new Mustang() as T;
                case "Charger":
                    return new Charger() as T; 
                default:
                    throw new Exception("Car isn't configured!");
            }
        }
    }
}
