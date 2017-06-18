namespace AbstractFactoryPattern.Interfaces
{
    using System.ComponentModel;

    internal interface ICar
    {
        void StartEngine();

        void StopEngine();

        void Drive(Direction direction, int speed);
    }
}
