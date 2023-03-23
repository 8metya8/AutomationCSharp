namespace Lesson_10
{
    /// <summary>
    /// Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
    /// Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива,
    /// получения элемента из массива по индексу и метод, возвращающий длину массива.
    /// </summary>
    internal class Task1
    {
        public static void HWTask1()
        {
            Console.WriteLine("----- Task 1 - Array -----");

            ArrayGeneric<string> array = new ArrayGeneric<string>();

            Console.WriteLine($"Lenght of array - {array.Lenght()}");

            array.Add("element1");
            array.Add("element2");
            array.Add("element3");
            array.Add("element2");
            array.Add("element4");

            Console.WriteLine($"\nLenght of new array - {array.Lenght()}");

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

            array.Delete("element2");
            Console.WriteLine($"\nLenght of new array - {array.Lenght()}");
            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Element 3 - {array.Get(2)}");
        }
    }
}
