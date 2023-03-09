namespace Lesson_6
{
    internal class Bus : PublicTransport
    {
        public Bus(int countOfSeats, string number, string destinationStation, DateTime departureTime, EngineTypeOfTransport engineType) 
            : base(countOfSeats, number, destinationStation, departureTime, engineType)
        {

        }

        public override string GetTransportType()
        {
            return "Bus";
        }
    }
}
