namespace AbstractFactoryPattern.Interfaces
{
    internal interface ICarFactory
    {
        T GetCar<T>() where T : class, ICar;
    }
}
