namespace Additional_HW 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 - Second max elemnt of array.");
            Task1.MaxAndSecondMax(new int[] { 2, 1, 5, 3, 4, 5});
            Task1.MaxAndSecondMax(new int[] { 8, 1, 15, 10, 7, 5, 11, 13});

            Console.WriteLine("\nTask 2 - Order array consisting of 0's and 1's.");
            Task2.OrderArray(new int[] { 0, 1, 0, 1 });
            Task2.OrderArray(new int[] { 1, 1, 0, 1, 1, 1, 0 });

            Console.WriteLine("\n\nTask 3 - Sequence of number.");
            var result = Task3.IsThereSequenceOfNumber(new int[] { 2, 3, 9, 4, 7, 16, 1, 18, 10, 4 }, 20);
            Console.WriteLine(result);
            result = Task3.IsThereSequenceOfNumber(new int[] { 2, 3, 9, 4, 7, 16, 1, 18, 10, 4 }, 30);
            Console.WriteLine(result);
        }
    }
}