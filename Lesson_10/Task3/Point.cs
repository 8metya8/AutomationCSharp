namespace Lesson_10
{
    internal class Point<T, K>
    {
        public T X { get; }
        public K Y { get; }

        public Point(T x, K y)
        {
            this.X = x;
            this.Y = y;
        }

        public void ShowCoordinates()
        {
            Console.WriteLine("X - " + X + ", Y - " + Y);
        }

        public double GetDistanseTo(Point<T, K> point)
        {            
            return Math.Round(Math.Sqrt( Math.Pow( Convert.ToInt32(point.X) - Convert.ToInt32(X), 2 ) + Math.Pow(Convert.ToInt32(point.Y) - Convert.ToInt32(Y), 2) ), 2);
        }
    }
}
