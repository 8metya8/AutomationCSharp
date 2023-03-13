namespace Lesson_6
{
    internal abstract class Auto
    {
        public string Brand { get; set; }
        public string  Number { get; set; }
        public int Speed { get; set; }
        public double LoadCapacity { get; set; }

        public abstract void ShowInfo();
        public abstract double GetLoadCapacity();
    }
}
