namespace Lesson_6
{
    internal class TriangleBuilder
    {
        public TriangleBuilder() 
        {

        }

        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
            }
            else if ((firstSide == secondSide && (firstSide != thirdSide)) 
                || (firstSide == thirdSide && (firstSide != secondSide)) 
                || (secondSide == thirdSide && (secondSide != firstSide)))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else if( (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)) 
                || (Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)) 
                || (Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)))
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }
            else
            {
                return new Triangle(firstSide, secondSide, thirdSide);
            }           
        }
    }
}
