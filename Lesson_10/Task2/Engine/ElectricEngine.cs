namespace Lesson_10
{
    internal class ElectricEngine : Engine
    {
        public override string Number { get; }
        public override FuelType FuelType { get; } = FuelType.electric;
        public ElectricEngine(string number)
        {
            this.Number = number;
        }
    }
}
