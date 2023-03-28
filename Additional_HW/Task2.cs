namespace Additional_HW
{
    /// <summary>
    /// Order array consisting of 0's and 1's, so that: 
    /// - 1's are on the right 
    /// - 0's are on the left 
    ///
    /// Examples: 
    /// Before [0, 1, 0 ,1] 
    /// After [0, 0, 1, 1] 
    /// Before [1, 1, 0, 1, 1, 1, 0] 
    /// After [0, 0, 1, 1, 1, 1, 1]
    /// </summary>
    internal class Task2
    {
        /// <summary>
        /// Show new ordered array: 1's are on the right and 0's are on the left 
        /// </summary>
        /// <param name="intArray"></param>
        public static void OrderArray(int[] intArray)
        {
            //Get count of zero in array and print old array
            Console.Write("\nOld array - ");
            int countOfZero = 0;
            foreach(int i in intArray)
            {
                if(i == 0)
                {
                    countOfZero++;
                }

                Console.Write(i + " ");
            }

            //Add zeros in start of new array and print it
            Console.Write("\nNew array - ");
            int[] orderedArray = new int[intArray.Length];
            for(int i = 0; i < orderedArray.Length; i++)
            {
                orderedArray[i] = countOfZero > 0 ? 0 : 1;
                countOfZero--;
                Console.Write(orderedArray[i] + " ");
            }
        }
    }
}
