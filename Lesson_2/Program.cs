namespace Lesson_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
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

            Console.WriteLine("----- Task 2 \"Ranges\" -----\n");
            Console.Write("Enter a value from 0 to 100:");

            int number = Convert.ToInt32(Console.ReadLine());

            if ((number >= 0) & (number <= 100))
                {
                if ((number >= 0) & (number <= 14))
                {
                    Console.Write("The value is in range [0 - 14].");
                }
                else if (number <= 35)
                {
                    Console.Write("The value is in range [15 - 35].");
                }
                else if (number <= 49)
                {
                    Console.Write("The value is in range [36 - 49].");
                }
                else if (number <= 100)
                {
                    Console.Write("The value is in range [50 - 100].");
                }
                else
                {
                    Console.Write("The value is in no one of range.");
                }
            }
            else
            {
                Console.Write("The value is not in range [0 - 100].");
            }
                                                           
        }

    }
}