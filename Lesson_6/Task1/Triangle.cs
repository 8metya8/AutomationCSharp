namespace Lesson_6
{
    internal class Triangle : Figure
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override double GetSquare()
        {
            double semiPerimetr = 0.5 * (firstSide + secondSide + thirdSide);
            return Math.Round(Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide)), 2);
        }
    }
}
