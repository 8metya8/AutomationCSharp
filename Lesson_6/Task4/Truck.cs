namespace Lesson_6
{
    internal class Truck :Auto
    {
        public bool HasTrailer { get; set; }

        public Truck(string brand, string number, int speed, double loadCapacity, bool hasTrailer)
        {
            Brand = brand;
            Number = number;
            Speed = speed;    
            LoadCapacity = loadCapacity;
            HasTrailer = hasTrailer;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.GetType().Name} \nBrand - {Brand} \nNumber - {Number} \nSpeed - {Speed} km/h \nHas trailer - {HasTrailer} \nLoadCapacity - {GetLoadCapacity()} ton(s).");
        }

        public override double GetLoadCapacity()
        {
            return HasTrailer ? LoadCapacity * 2 : LoadCapacity;
        }
    }
}
