namespace Lesson_6
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }
        public override double GetSquare()
        {
            return Math.Round(GetIsoscelesTriangle(firstSide, secondSide, thirdSide), 2);
        }

        private double GetIsoscelesTriangle(double firstSide, double secondSide, double thirdSide)
        {

            if (firstSide == secondSide)
            {
                return 0.5 * thirdSide * Math.Sqrt(Math.Pow(firstSide, 2) - (Math.Pow(thirdSide, 2) * 0.25));
            }
            else if (firstSide == thirdSide)
            {
                return 0.5 * secondSide * Math.Sqrt(Math.Pow(firstSide, 2) - (Math.Pow(secondSide, 2) * 0.25));
            }
            else
            {
                return 0.5 * firstSide * Math.Sqrt(Math.Pow(secondSide, 2) - (Math.Pow(firstSide, 2) * 0.25));
            }
        }
    }
}
