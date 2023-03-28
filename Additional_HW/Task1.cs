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

            //Get max element and average value.
            var max = array[0];
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }

                sum += array[i];
            }

            var avg = sum / array.Length;

            //Search max element between Max and Avg 
            var secondMax = 0;
            foreach (int i in array)
            {
                if((i > avg) && (i < max) && (i > secondMax))
                {
                    secondMax = i;
                }
            }

            Console.WriteLine($"Max = {max}, secondMax = {secondMax}");
        }

    }
}
