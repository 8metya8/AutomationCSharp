namespace Lesson_6
{
    internal class Tram : PublicTransport
    {
        public Tram(EngineType engineType, ModesOfTransport modesOfTransport, int countOfSeats, string number, string destinationStation, DateTime departureTime)
            : base(engineType, modesOfTransport, countOfSeats, number, destinationStation, departureTime)
        {

        }

        public override string GetTransportType()
        {
            return $"Tram is {base.GetTransportType()}";
        }
    }
}
