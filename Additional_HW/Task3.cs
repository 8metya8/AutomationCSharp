namespace Additional_HW
{
    internal class Task3
    {
        /// <summary>
        /// The method will return true/false if there is a sequence of numbers whose sum is equals to the number received.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsThereSequenceOfNumber(int[] intArray, int number)
        {
            //Get sum of elements, start from first element, while sum < number.
            //if sum = number return true. If sum > number break and start from next element of array.
            for (int i = 0; i < intArray.Length; i++)
            {
                var sum = 0;

                for (int index = i; index < intArray.Length; index++)
                {
                    sum += intArray[index];

                    if (sum > number)
                    {
                        break;
                    }
                    else if(sum == number)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
