namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        /// <summary>
        /// Заменить в строке все вхождения 'test' на 'testing'. 
        /// Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        public static void Task1()
        {
            Console.WriteLine("----- Task 1 \"Replace and remove\" -----\n");

            string str = "test1 create new test and start regression test 10";
            Console.WriteLine("Default string: '" + str + "'");

            string resultOfReplace = str.Replace("test", "testing");
            Console.WriteLine("String after replace: '" + resultOfReplace + "'");

            string resultOfRemoveDigits = "";
            for(int i = 0; i < str.Length; i++)
            {
                if( !Char.IsDigit(str, i) )
                {
                    resultOfRemoveDigits += str[i];
                }
            }

            Console.WriteLine("String after delete all digits: '" + resultOfRemoveDigits + "'");
        }

        /// <summary>
        /// Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Welcome to the TMS lesons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("\n----- Task 2 \"Concatenation\" -----\n");

            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lessons";
            string word6 = ".";

            Console.WriteLine(word1 + " " + word2 + " " + word3 + " " + word4 + " " + word5 + word6);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("\n----- Task 3 \"Split or Substring\" -----\n");

            string defaultString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string firstVarible = defaultString.Substring(0, defaultString.IndexOf("abc"));
            string secondVarible = defaultString.Substring(defaultString.IndexOf("abc") + 3);

            Console.WriteLine($"Default string - {defaultString}");
            Console.WriteLine($"First varible - {firstVarible}");
            Console.WriteLine($"Second varible - {secondVarible}");

            //Also we can use method Split
            string[] phrases = defaultString.Split("abc");
            Console.WriteLine("\nThe second way of resolving:");
            Console.WriteLine($"First varible - {phrases[0]}");
            Console.WriteLine($"Second varible - {phrases[1]}");
        }

        /// <summary>
        /// Дана строка: Плохой день.
        /// Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        /// Заменить последний "!" на "?"
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("\n----- Task 4 \"Substring\" -----\n");
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("utf-16");

            string defaultString = "Плохой день.";
            string subString = defaultString.Substring(6);
            subString = subString.Insert(0, "Хороший");
            subString = subString.Insert(subString.Length - 1, "!!!!!!!!!");
            subString = subString.Replace("!!!!!!!!!", "!!!!!!!!?");

            Console.WriteLine("Defaul string - " + defaultString);
            Console.WriteLine("Result - " + subString);
        }
    }
}