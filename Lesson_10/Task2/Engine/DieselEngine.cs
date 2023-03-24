namespace Lesson_10
{
    internal class DieselEngine : Engine
    {
        public override string Number { get; }
        public override FuelType FuelType { get; } = FuelType.diesel;

        public DieselEngine(string number)
        {
            this.Number = number;
        }
    }
}
