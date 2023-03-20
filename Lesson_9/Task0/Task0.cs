using System.Collections;

namespace Lesson_9
{
    internal class Task0
    {
        /// <summary>
        /// У вас есть следующая коллекция: 
        /// ArrayList list = new ArrayList();
        /// И в вашей программе вызвается следующий код:
        /// object s = list[18];
        /// Необходимо перехватить ошибку и вывести на экран с указанием типа этой ошибки.
        /// </summary>
        public static void Task_ArrayException()
        {
            Console.WriteLine("----- Task 0 Array Exception -----");
            try
            {
                ArrayList list = new ArrayList();
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Argument Out Of Range Exception:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Необходимо создать коллекцию Dictionary, в которой будет находиться 10 различных пар объектов. Необходимо вывести содержимое коллекции на экран.
        /// </summary>
        public static void Task_Dictionary()
        {
            Console.WriteLine("\n----- Task 0 Dictionary -----");

            Dictionary<object, object> dictionary = new Dictionary<object, object>();
            dictionary.Add("One", 1);
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            dictionary.Add(6, "Six");
            dictionary.Add("Seven", 7);
            dictionary.Add("Eight", 8);
            dictionary.Add(9, "Nine");
            dictionary.Add(10, "Ten");

            foreach(var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
