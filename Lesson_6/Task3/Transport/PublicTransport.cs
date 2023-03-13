namespace Lesson_6
{
    internal class PublicTransport : Transport
    {    
        public int CountOfSeats { get; set; }
        public string Number { get; set; }
        public string DestinationStation { get; set; }
        public DateTime DepartureTime { get; set; }

        public PublicTransport(EngineType engineType, ModesOfTransport modesOfTransport, int countOfSeats, string number, string destinationStation, DateTime departureTime )
        { 
            this.EngineType = engineType;
            this.ModesOfTransport = modesOfTransport;
            this.CountOfSeats = countOfSeats;
            this.Number = number;
            this.DestinationStation = destinationStation;
            this.DepartureTime = departureTime;
        }

        /// <summary>
        /// If transport1.CountOfSeats > transport2.CountOfSeats return true, otherwise false.
        /// </summary>
        /// <param name="transport1"></param>
        /// <param name="transport2"></param>
        /// <returns></returns>
        public static bool Compare(PublicTransport transport1, PublicTransport transport2)
        {
            return transport1.CountOfSeats > transport2.CountOfSeats ? true : false;
        }

        public static void Sort(PublicTransport[] array)
        {
            PublicTransport tempVerible;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (PublicTransport.Compare(array[j], array[j + 1]))
                    {
                        tempVerible = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tempVerible;
                    }
                }
            }
        }

        /// <summary>
        /// If time == DepartureTime add to List, return List of PublicTransport.
        /// </summary>
        /// <param name="publicTransport"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static IList<PublicTransport> SearchByTime(PublicTransport[] publicTransport, DateTime time)
        {
            IList<PublicTransport> transportByTime = new List<PublicTransport>();
            foreach(var transport in publicTransport)
            {
                if(transport.DepartureTime == time)
                {
                    transportByTime.Add(transport);
                }
            }

            return transportByTime;
        }

        public static IList<PublicTransport> SearchAfterTime(PublicTransport[] publicTransport, DateTime time)
        {
            IList<PublicTransport> transportByTime = new List<PublicTransport>();
            foreach (var transport in publicTransport)
            {
                if (transport.DepartureTime > time)
                {
                    transportByTime.Add(transport);
                }
            }

            return transportByTime;
        }

        public static IList<PublicTransport> SearchByTimeAndDestination(PublicTransport[] publicTransport, DateTime time, string destination)
        {
            IList<PublicTransport> transportByTimeAndDestination = new List<PublicTransport>();
            foreach (var transport in publicTransport)
            {
                if ( (transport.DepartureTime == time) && (transport.DestinationStation.ToUpper().Equals(destination)))
                {
                    transportByTimeAndDestination.Add(transport);
                }
            }

            return transportByTimeAndDestination;
        }

        public static IList<PublicTransport> SearchByDestination(PublicTransport[] publicTransport, string destination)
        {
            IList<PublicTransport> transportByTime = new List<PublicTransport>();
            foreach (var transport in publicTransport)
            {
                if (transport.DestinationStation.ToUpper().Equals(destination))
                {
                    transportByTime.Add(transport);
                }
            }

            return transportByTime;
        }
    }
}
