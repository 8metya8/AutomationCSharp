namespace Lesson_6
{
    internal class Tram : PublicTransport
    {
        public Tram(int countOfSeats, string number, string destinationStation, DateTime departureTime, EngineTypeOfTransport engineType)
            : base(countOfSeats, number, destinationStation, departureTime, engineType)
        {

        }

        public override string GetTransportType()
        {
            return "Tram";
        }
    }
}
