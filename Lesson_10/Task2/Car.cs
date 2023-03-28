namespace Lesson_10
{
    internal class Car<T> where T : Engine
    {
        T engine;
        int maxRangeOfVehicle;
        int rangeOfVehicle = 0;

        public int RangeOfVehicle
        {
            get 
            { 
                return rangeOfVehicle;
            }
        }

        public Car(T engine, int maxRangeOfVehicle)
        {
            this.engine = engine;
            this.maxRangeOfVehicle = maxRangeOfVehicle;
        }

        public void Move(int distance)
        {
            if ((rangeOfVehicle == 0) || (distance > rangeOfVehicle))
            {
                Console.WriteLine("Car needs gas.");
            }
            else
            {
                Console.WriteLine($"Car is moving {distance} km.");
                rangeOfVehicle -= distance;
            }

            Console.WriteLine($"Range Of Vehicle - {RangeOfVehicle} km.");
        }

        public void GasUp()
        {
            rangeOfVehicle = maxRangeOfVehicle;

            switch (engine.FuelType)
            {
                case FuelType.diesel:

                    Console.WriteLine("The car is fully fueled.");
                    break ;
                case FuelType.gasoil:
                    Console.WriteLine("The car is fully fueled.");
                    break ;
                case FuelType.electric:
                    Console.WriteLine("The car is fully charged.");
                    break;
                default:
                    Console.WriteLine("Unknown engine type.");
                    break ;
            }                       
        }

    }
}
