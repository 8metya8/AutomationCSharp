namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task8();
        }

        /// <summary>
        /// Создайте массив целых чисел. 
        /// Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. 
        /// Пусть число для поиска задается с консоли.
        /// </summary>
        public static void Task0()
        {
            int[] array = { 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("----- Task 0 \"Contains or Not contains\" -----\n");
            Console.Write("Enter any integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isContains = false;

            foreach (int n in array)
            {
                if (n == number)
                {
                    isContains = true;
                    break;
                }
            }

            string result = isContains ? "contains" : "doesn't contain";

            Console.WriteLine($"Array {result} number - {number}");

        }

        /// <summary>
        /// Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        /// В результате должен быть новый массив без указанного числа.
        /// </summary>
        public static void Task1()
        {
            int[] array = { 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("----- Task 1 \"Delete number from array.\" -----\n");
            Console.Write("Enter any integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isContains = false;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    isContains = true;
                    index = i;
                    break;
                }
            }

            if(isContains)
            {
                int[] result = new int[array.Length - 1];

                Array.Copy(array, result, index);
                Array.Copy(array, index + 1, result, index, result.Length - index);

                Console.Write("Old array: ");
                foreach (int n in array)
                {
                    Console.Write(n + " ");
                }

                Console.Write("\nNew array: ");
                foreach (int n in result)
                {                  
                    Console.Write(n + " ");
                }
            }
            else
            {
                Console.WriteLine($"Array doesn't contain number - {number}");
            }
        }

        /// <summary>
        /// Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        /// Для генерации случайного числа используйте метод Random() . 
        /// Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("----- Task 2 \"Max,min and avg number in array.\" -----\n");
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nArray: ");

            int[] arrayRandom = new int[size];
            Random random = new Random();
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                arrayRandom[i] = random.Next(0, 50);
                sum += arrayRandom[i];

                Console.Write(arrayRandom[i] + " ");
            }

            Console.WriteLine($"\nAvg = " + Math.Round((sum / size), 3));

            int max = arrayRandom[0];
            int min = arrayRandom[0];

            foreach (int n in arrayRandom)
            {
                max = n > max ? n : max;
                min = n < min ? n : min;
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }

        /// <summary>
        /// Создайте 2 массива из 5 чисел.
        /// Выведите массивы на консоль в двух отдельных строках.
        /// Посчитайте среднее арифметическое элементов каждого массива и сообщите, 
        /// для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("----- Task 2 \"Two arrays and avg.\" -----\n");
            
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            double sumFirstArray = 0;
            double sumSecondArray = 0;

            Random random = new Random();

            Console.Write("\nThe first array: ");
            for (int i = 0; i < 5; i++)
            {
                firstArray[i] = random.Next(0, 50);
                sumFirstArray += firstArray[i];
                Console.Write(firstArray[i] + " ");
            }

            Console.Write("\nThe second array: ");
            for (int i = 0; i < 5; i++)
            {
                secondArray[i] = random.Next(0, 50);
                sumSecondArray += secondArray[i];
                Console.Write(secondArray[i] + " ");
            }

            if ((sumFirstArray / 5) > (sumSecondArray / 5))
            {
                Console.WriteLine("\nThe avg of the first array greater than the avg of the second array.");
            }
            else if ((sumFirstArray / 5) < (sumSecondArray / 5))
            {
                Console.WriteLine("\nThe avg of the second array greater than the avg of the first array.");
            }
            else
            {
                Console.WriteLine("\nThe avg are the same.");
            }              
        }

        /// <summary>
        /// Создайте массив из n случайных целых чисел и выведите его на экран.
        /// Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
        /// Если n не удовлетворяет условию - выведите сообщение об этом.
        /// Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
        /// Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("----- Task 4 \"Array and even array.\" -----");
            
            int size = 0;
            bool isRightSize = false;


            do 
            {                
                try
                {
                    Console.Write("\nEnter size of array (size must be greater than 5, but less than 11): ");
                    size = Convert.ToInt32(Console.ReadLine());

                    if ((size > 5) && (size < 11))
                    {
                        isRightSize = true;
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered wrong size of array. Please, try again.");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\nYou entered not number.");
                }
                
            } while (!isRightSize);

            int[] numbers = new int[size];
            Random random = new Random();
            int  countOfEvenNumber = 0;

            Console.Write("\nDefault array: ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(0, 200);
                Console.Write(numbers[i] + " ");

                if (numbers[i] % 2 == 0)
                {
                    countOfEvenNumber++;
                }
            }

            if (countOfEvenNumber > 0)
            {
                int[] evenNumbers = new int[countOfEvenNumber];
                int index = 0;

                foreach (int number in numbers)
                {
                    if(number % 2 == 0)
                    {
                        evenNumbers[index] = number;
                        index++;
                    }
                }

                Console.Write("\nEven array: ");
                foreach(int number in evenNumbers)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                Console.WriteLine("\nDefault array does not contain even numbers.");
            }           
        }

        /// <summary>
        /// Создайте массив и заполните массив.
        /// Выведите массив на экран в строку.
        /// Замените каждый элемент с нечётным индексом на ноль.        
        /// Снова выведете массив на экран на отдельной строке.
        /// </summary>
        public static void Task5()
        {
            Console.WriteLine("----- Task 5 \"Array and odd index.\" -----\n");

            int[] numbers = new int[10];
            Random random = new Random();

            Console.Write("\nThe array: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(0, 50);
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\nNew array: ");
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 != 0)
                {
                    numbers[i] = 0;
                }

                Console.Write(numbers[i] + " ");
            }
        }

        /// <summary>
        /// Создайте массив строк. Заполните его произвольными именами людей.
        /// Отсортируйте массив.
        /// Результат выведите на консоль.
        /// </summary>
        public static void Task6()
        {
            Console.WriteLine("----- Task 6 \"Array of names.\" -----\n");

            string[] names = { "Liam", "Olivia", "Noah", "Emma", "Oliver", "Charlotte", "Elijah", "Amelia", "James", "Ava" };

            Console.Write("Array before sort: ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }

            Array.Sort(names);

            Console.Write("\nArray after sort: ");
            foreach(string name in names)
            {
                Console.Write($"{name} ");
            }
        }

        /// <summary>
        /// Реализуйте алгоритм сортировки пузырьком.
        /// </summary>
        public static void Task7()
        {
            Console.WriteLine("----- Task 7 \"Bubиle.\" -----\n");

            int[] numbers = new int[15];
            Random random = new Random();

            Console.Write("\nThe array before sort: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 50);
                Console.Write(numbers[i] + " ");
            }

            int tempVerible;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tempVerible = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = tempVerible;
                    }
                }
            }

            Console.Write("\nThe array after sort: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        /// <summary>
        /// Умножение двух матриц Создайте два массива целых чисел размером 3х3 (две матрицы).
        /// Напишите программу для умножения двух матриц. Первый массив: {{1,0,0,0},{0,1,0,0},{0,0,0,0}} 
        /// Второй массив: {{1,2,3},{1,1,1},{0,0,0},{2,1,0}} 
        /// Ожидаемый результат: 1 2 3 1 1 1 0 0 0
        /// </summary>
        public static void Task8()
        {
            
        }

        /// <summary>
        /// Создайте двумерный массив целых чисел. Выведите на консоль сумму всех элементов массива.
        /// </summary>
        public static void Task9()
        {
            Console.WriteLine("----- Task 9 \"Multidimensional array.\" -----\n");

            int[,] numbers = new int[4,7];
            int sum = 0;
            Random random = new Random();

            Console.WriteLine("\nThe array: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                    sum += numbers[i, j];
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Sum = " + sum);
        }

        /// <summary>
        /// Создайте двумерный массив. Выведите на консоль диагонали массива.
        /// </summary>
        public static void Task10()
        {
            Console.WriteLine("----- Task 10 \"Multidimensional array - diagonals.\" -----\n");

            int[,] numbers = new int[7, 7];
            int sum = 0;
            Random random = new Random();

            Console.WriteLine("\nThe array: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                    sum += numbers[i, j];
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.Write("\nMain diagonal: ");
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write(numbers[i, i] + " ");
            }

            Console.Write("\nSubdiagonal: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {                
                Console.Write(numbers[numbers.GetLength(0) - 1 - i, i] + " ");
            }
        }

        /// <summary>
        /// Создайте двумерный массив целых чисел. Отсортируйте элементы в строках двумерного массива по возрастанию.
        /// </summary>
        public static void Task11()
        {
            Console.WriteLine("----- Task 11 \"Multidimensional array - diagonals.\" -----\n");

            int[,] numbers = new int[3, 5];
            int sum = 0;
            Random random = new Random();

            Console.WriteLine("\nThe array: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                    sum += numbers[i, j];
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
            
            int tempVerible;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {                     
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {                                     
                        for (int n = 0; n < numbers.GetLength(1) - 1; n++)
                        {
                            if (numbers[i, n] > numbers[i, n + 1])
                            {
                                tempVerible = numbers[i, n + 1];
                                numbers[i, n + 1] = numbers[i, n];
                                numbers[i, n] = tempVerible;
                            }
                        }                   
                }
            }

            Console.WriteLine("\nThe array after sort: ");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
    