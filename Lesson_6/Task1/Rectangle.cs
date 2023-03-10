namespace Lesson_6
{
    internal class Rectangle : Figure
    {
        double firstSide;
        double secondSide;

        public Rectangle(double firstSide, double secondSide)
        { 
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }
        public override double GetSquare()
        {
            return Math.Round(firstSide * secondSide, 2);
        }
    }
}
