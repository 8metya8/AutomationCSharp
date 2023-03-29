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
            //Find zero and set it to the left
            int indexOfZero = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if(intArray[i] == 0)
                {
                    intArray[i] = 1;
                    intArray[indexOfZero] = 0;
                    indexOfZero++;
                }
            }
        }
    }
}
