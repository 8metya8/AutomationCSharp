namespace Additional_HW
{
    /// <summary>
    /// дан массив целых чисел 
    /// вывести второе максимальное число
    /// сортировку из коробки не используем
    /// входные данные
    /// int[] intArray = { 2, 1, 5, 3, 4, 5 };
    /// должно вернуть 4
    /// </summary>
    internal class Task1
    {
        static int[] array;
        /// <summary>
        /// Show second max value in array
        /// </summary>
        /// <param name="intArray"></param>
        public static void MaxAndSecondMax(int[] intArray)
        {
            array = intArray;

            //Get max element and second max
            var max = array[0];
            var secondMax = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {                    
                    max = array[i];                    
                }
                else if ((array[i] > secondMax) && (array[i] != max))
                {
                    secondMax = array[i]; ;
                }
            }

            Console.WriteLine($"Max = {max}, secondMax = {secondMax}");
        }

    }
}
