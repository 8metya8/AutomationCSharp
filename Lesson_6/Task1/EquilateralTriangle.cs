namespace Lesson_6
{
    internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }
        public override double GetSquare()
        {
            return Math.Round(Math.Sqrt(3) * Math.Pow(firstSide, 2) * 0.25, 2);
        }
    }
}
