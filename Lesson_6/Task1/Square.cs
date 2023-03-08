namespace Lesson_6
{
    internal class Square : Figure
    {
        double sideSquare;

        public Square(double sideSquare)
        {
            this.sideSquare = sideSquare;
        }
        public override double GetSquare()
        {
            return Math.Round(Math.Pow(sideSquare, 2), 2);
        }
    }
}
