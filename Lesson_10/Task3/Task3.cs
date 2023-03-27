namespace Lesson_10
{
    /// <summary>
    /// Реализовать обобщенный класс Point, который определяет точку на координатной плоскости. В классе реализовать:
    /// обобщенные внутренние поля x, y;
    /// конструктор с 2 параметрами;
    /// свойства доступа к внутренним полям класса;
    /// метод, выводящий значения внутренних полей класса
    /// метод нахождения расстояния с другой точкой
    /// </summary>
    internal class Task3
    {
        public static void HWTask3()
        {
            Point<int, int> point1 = new Point<int, int>(1, 5);
            Point<int, int> point2 = new Point<int, int>(4, 15);

            point1.ShowCoordinates();
            point2.ShowCoordinates();

            Console.WriteLine($"Distanse between two points - {point1.GetDistanseTo(point2)}");
        }
    }
}
