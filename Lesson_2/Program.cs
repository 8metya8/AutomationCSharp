namespace Lesson_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
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

    }
}