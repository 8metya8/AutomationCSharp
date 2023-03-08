namespace Lesson_6
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {

        }

        public override double GetSquare()
        {
            if (firstSide > secondSide)
            {
                if (firstSide > thirdSide)
                {
                    return GetSquareRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    return GetSquareRightTriangle(firstSide, secondSide);
                }
            }
            else
            {
                if (secondSide > thirdSide)
                {
                    return GetSquareRightTriangle(firstSide, thirdSide);
                }
                else
                {
                    return GetSquareRightTriangle(firstSide, secondSide);
                }
            }
        }

        private double GetSquareRightTriangle(double firstSide, double secondSide)
        {
            return Math.Round(0.5 * (firstSide * secondSide), 2);
        }
    }
}
