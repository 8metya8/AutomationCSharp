namespace Lesson_6
{
    internal class Motorcycle : Auto
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string brand, string number, int speed, double loadCapacity, bool hasSidecar)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            LoadCapacity = loadCapacity;
            HasSidecar = hasSidecar;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.GetType().Name} \nBrand - {Brand} \nNumber - {Number} \nSpeed - {Speed} km/h \nHas sidecar - {HasSidecar} \nLoadCapacity - {GetLoadCapacity()} ton(s).");
        }

        public override double GetLoadCapacity()
        {
            return HasSidecar ? LoadCapacity : 0;
        }
    }
}
