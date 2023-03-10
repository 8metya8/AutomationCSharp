namespace Lesson_6
{
    internal class Trolleybus : PublicTransport
    {
        public Trolleybus(int countOfSeats, string number, string destinationStation, DateTime departureTime, EngineTypeOfTransport engineType)
            : base(countOfSeats, number, destinationStation, departureTime, engineType)
        {

        }
        public override string GetTransportType()
        {
            return "Trolleybus";
        }
    }
}
