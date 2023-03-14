namespace Lesson_6
{
    internal class Trolleybus : PublicTransport
    {
        public Trolleybus(EngineType engineType, ModesOfTransport modesOfTransport, int countOfSeats, string number, string destinationStation, DateTime departureTime)
            : base(engineType, modesOfTransport, countOfSeats, number, destinationStation, departureTime)
        {

        }
        public override string GetTransportType()
        {
            return $"Trolleybus is {base.GetTransportType()}";
        }
    }
}
