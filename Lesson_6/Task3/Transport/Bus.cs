namespace Lesson_6
{
    internal class Bus : PublicTransport
    {
        public Bus(EngineType engineType, ModesOfTransport modesOfTransport, int countOfSeats, string number, string destinationStation, DateTime departureTime) 
            : base(engineType, modesOfTransport, countOfSeats, number, destinationStation, departureTime)
        {

        }

        public override string GetTransportType()
        {
            return $"Bus is {base.GetTransportType()}";
        }

    }
}
