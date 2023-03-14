namespace Lesson_6
{
    internal class Car : Auto
    {
        public Car(string brand, string number, int speed, double loadCapacity)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            LoadCapacity = loadCapacity;
        }
        public override double GetLoadCapacity()
        {
            return LoadCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{this.GetType().Name} \nBrand - {Brand} \nNumber - {Number} \nSpeed - {Speed} km/h \nLoadCapacity - {GetLoadCapacity()} ton(s).");
        }

    }
}
