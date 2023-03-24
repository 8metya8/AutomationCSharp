namespace Lesson_10
{
    internal class GasoilEngine : Engine
    {
        public override string Number { get;}
        public override FuelType FuelType { get; } = FuelType.gasoil;

        public GasoilEngine(string number)
        {
            this.Number = number;
        }

    }
}
