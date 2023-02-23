namespace Lesson_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }

        public static void Task1()
        {
            //Напишите программу -консольный калькулятор.
            //Создайте две переменные с именами operand1 и operand2.
            //Задайте переменным некоторые произвольные значения.
            //Предложите пользователю ввести знак арифметической операции.
            //Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
            //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
            //Выведите на экран результат выполнения арифметической операции.
            //**В случае использования операции деления, организуйте проверку попытки деления на ноль.
            //И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

            Console.WriteLine("----- Task 1 \"Calculator\" -----\n");           

            Console.Write("Enter the first operand:");
            decimal operand1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("Enter the second operand:");
            decimal operand2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Select an operation ( +, -, *, / ):");
            string sign = Console.ReadLine();

            Console.WriteLine("\n****** THE RESULT ******");

            switch (sign)
            {
                case "+":                    
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {Math.Round(operand1 * operand2, 6)}");
                    Console.WriteLine("*The result has been round to 6 digits after zero.");
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine($"{operand1} / {operand2} = {Math.Round(operand1 / operand2, 6)}");
                        Console.WriteLine("*The result has been round to 6 digits after zero.");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero!");
                    }                    
                    break;
                default: 
                    Console.WriteLine("You selected undefined operation.");
                    break;
            }
        }

        public static void Task2()
        {
            // Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 49][50 - 100].
            // Если да, то укажите, в какой именно промежуток.
            // Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.

            Console.WriteLine("\n----- Task 2 \"Ranges\" -----\n");
            Console.Write("Enter a value from 0 to 100:");

            int number = Convert.ToInt32(Console.ReadLine());

            if ((number >= 0) && (number <= 100))
                {
                if ((number >= 0) && (number <= 14))
                {
                    Console.WriteLine("The value is in range [0 - 14].");
                }
                else if (number <= 35)
                {
                    Console.WriteLine("The value is in range [15 - 35].");
                }
                else if (number <= 49)
                {
                    Console.WriteLine("The value is in range [36 - 49].");
                }
                else if (number <= 100)
                {
                    Console.WriteLine("The value is in range [50 - 100].");
                }
                else
                {
                    Console.WriteLine("The value is in no one of range.");
                }
            }
            else
            {
                Console.WriteLine("The value is not in range [0 - 100].");
            }
                                                           
        }

        public static void Task3()
        {
            // Напишите программу русско - английский переводчик.
            // Программа знает 10 слов о погоде.
            // Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
            // Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
            
            //Set encoding for russian symbols
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("utf-16");

            Console.WriteLine("\n----- Task 3 \"Dictionary\" -----\n");
            Console.Write("Enter russion word (Topic is the weather.): ");
            string word = Console.ReadLine().ToLower();

            switch(word)
            {
                case "дождь":
                    Console.WriteLine("\nRUS Дождь - ENG Rain");
                    break;
                case "снег":
                    Console.WriteLine("\nRUS Снег - ENG Snow");
                    break;
                case "солнце":
                    Console.WriteLine("\nRUS Солнце - ENG Sun");
                    break;
                case "туман":
                    Console.WriteLine("\nRUS Туман - ENG Fog");
                    break;
                case "облако":
                    Console.WriteLine("\nRUS Облако - ENG Cloud");
                    break;
                case "ветер":
                    Console.WriteLine("\nRUS Ветер - ENG Wind");
                    break;
                case "небо":
                    Console.WriteLine("\nRUS Небо - ENG Sky");
                    break;
                case "холодно":
                    Console.WriteLine("\nRUS Холодно - ENG Cold");
                    break;
                case "жарко":
                    Console.WriteLine("\nRUS Жарко - ENG Hot");
                    break;
                case "тепло":
                    Console.WriteLine("\nRUS Тепло - ENG Warm");
                    break;
                default:
                    Console.WriteLine($"\nDictionary doesn't contain word '{word}'.");
                    break;
            }
        }

        public static void Task4()
        {
            // Напишите программу, которая будет выполнять проверку чисел на четность.
            // Предложите два варианта решения поставленной задачи.

            Console.WriteLine("\n----- Task 4 \"Even\" -----\n");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt16(Console.ReadLine());

            //First way to solve 
            if ((number % 2) == 0)
            {
                Console.WriteLine($"\n{number} is even number. ");
            }
            else
            {
                Console.WriteLine($"\n{number} is odd number. ");
            }

            //Second way to solve
            // В двоичной системе у четного числа первый бит = 0 и если выполнить логическое умножение (&) на 1 (0001),
            // то если число четное на выходе получим 0.
            
            if ((number & 1) == 0)
            {
                Console.WriteLine($"\n{number} is even number. ");
            }
            else
            {
                Console.WriteLine($"\n{number} is odd number. ");
            }
        }

        public static void Task5()
        {
            //Даны x, y, z – вещественные числа. Существует ли треугольник с длинами сторон x, y, z? Если существует, то ответить, является ли он остроугольным.
            
            Console.WriteLine("\n----- Task 5 \"Triangle\" -----\n");
            Console.Write("Enter 1st side of a triangle: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd side of a triangle: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 3rd side of a triangle: ");
            double z = Convert.ToDouble(Console.ReadLine());

            if(((x + y) > z) && ((x + z) > y) && ((y + z) > x))
            {
                Console.WriteLine("The triangle is exist.");
                
                if ((x > y) && (x > z))
                {
                    if (Math.Pow(x, 2) < (Math.Pow(y, 2) + Math.Pow(z, 2)))
                    {
                        Console.WriteLine("The triangle is acute."); 
                    }
                    else
                    {
                        Console.WriteLine("The triangle is obtuse.");
                    }
                }
                else if((y > x) && (y > z))
                {
                    if (Math.Pow(y, 2) < (Math.Pow(x, 2) + Math.Pow(z, 2)))
                    {
                        Console.WriteLine("The triangle is acute.");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is obtuse.");
                    }
                }
                else
                {
                    if (Math.Pow(z, 2) < (Math.Pow(x, 2) + Math.Pow(y, 2)))
                    {
                        Console.WriteLine("The triangle is acute.");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is obtuse.");
                    }
                }
            }
            else
            {
                Console.WriteLine("The triangle is not exist.");
            }
        }

        public static void Task6()
        {
            //Даны вещественные числа a, b, c, d. Если a ≤ b ≤ c ≤ d, то каждое число заменить наибольшим,
            //если a > b > c > d,  то числа оставить без изменений,
            //в противном случае – все числа заменить их квадратами.

            Console.WriteLine("\n----- Task 6 \"Numbers\" -----\n");
            Console.Write("Enter 1st number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 4th number: ");
            double d = Convert.ToDouble(Console.ReadLine());

            if ((a <= b) && (b <= c) && (c <= d))
            {
                a = b = c = d;
                Console.WriteLine($"A = {a}, B = {b}, C = {c}, D = {d}");
            }
            else if ((a > b) && (b > c) && (c > d))
            {
                Console.WriteLine($"A = {a}, B = {b}, C = {c}, D = {d}");
            }
            else
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                c = Math.Pow(c, 2);
                d = Math.Pow(d, 2);

                Console.WriteLine($"A = {a}, B = {b}, C = {c}, D = {d}");
            }
        }

        public static void Task7()
        {
            //Поле шахматной доски определяется парой натуральных чисел, 
            //каждое из которых не превосходит 8: первое – номер вертикали, второе – номер горизонтали. Заданы натуральные числа k, l, m, n.
            //Определить, являются ли поля(k, l) и(m, n) одного цвета.
            //На поле(k, l) расположен конь. Угрожает ли он полю(m, n)?

            Console.WriteLine("\n----- Task 7 \"Chess\" -----\n");
            Console.WriteLine("Enter coordinates for 1st chessman. Coordinate must be 1 - 8.");
            Console.Write("X coordinate: ");
            byte k = Convert.ToByte(Console.ReadLine());

            Console.Write("Y coordinate: ");
            byte l = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\nEnter coordinates for 2st chessman.");
            Console.Write("X coordinate: ");
            byte m = Convert.ToByte(Console.ReadLine());

            Console.Write("Y coordinate: ");
            byte n = Convert.ToByte(Console.ReadLine());

            //If both coordinates are even or both coordinates are odd, then  color is black. If one coordinate is even and another is odd, then color is white.
            if ((((k % 2 == 0) && (l % 2 == 0)) || ((k % 2 != 0) && (l % 2 != 0))) && (((m % 2 == 0) && (n % 2 == 0)) || ((m % 2 != 0) && (n % 2 != 0))))
            {
                Console.WriteLine("\nBoth chessmans are on places with black color.");
                Console.WriteLine($"The Knight on {k}, {l} is not  dangerous  for {m},{n}");
            }
            else if ((((k % 2 != 0) && (l % 2 == 0)) || ((k % 2 == 0) && (l % 2 != 0))) && (((m % 2 != 0) && (n % 2 == 0)) || ((m % 2 == 0) && (n % 2 != 0))))
            {
                Console.WriteLine("\nBoth chessmans are on places with white color.");
                Console.WriteLine($"The Knight on {k}, {l} is not  dangerous  for {m},{n}");
            }
            else
            {
                Console.WriteLine("\nChessmans are on places with different color.");

                if ( (((l+2) == n) || ((l - 2) == n)) && ((k+1 == m) || (k - 1 == m)))
                {
                    Console.WriteLine($"The Knight on {k}, {l} is dangerous  for {m},{n} on current move.");
                }
                else
                {
                    Console.WriteLine($"The Knight on {k}, {l} is not  dangerous  for {m},{n} on current move.");
                }
            }

        }

    }
}