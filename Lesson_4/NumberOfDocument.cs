using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_4
{
    internal class NumberOfDocument
    {
        /// <summary>
        /// Вывести на экран в одну строку два первых блока по 4 цифры.
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void ShowTwoFirstBloksOfDigital(string numberOfDocument)
        {
            string[] partsOfnumber = numberOfDocument.Split('-');
            Console.WriteLine("Two first bloks of digital - " + partsOfnumber[0] + partsOfnumber[2]);
        }

        /// <summary>
        /// Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void ShowPartialNumber(string numberOfDocument)
        {
            string[] partsOfDocumentNumber = numberOfDocument.Split('-');

            for (int i = 0; i < partsOfDocumentNumber.Length; i++)
            {
                if(!Regex.IsMatch(partsOfDocumentNumber[i], "[0-9]"))
                {
                    partsOfDocumentNumber[i] = "***";
                }
            }

            Console.WriteLine($"Partial number of document: {partsOfDocumentNumber[0]}-{partsOfDocumentNumber[1]}-{partsOfDocumentNumber[2]}" +
                $"-{partsOfDocumentNumber[3]}-{partsOfDocumentNumber[4]}");
        }

        /// <summary>
        /// Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void ShowLetters(string numberOfDocument)
        {
            string[] partsOfDocumentNumber = numberOfDocument.Split('-');
            string result = "";

            foreach(string part in partsOfDocumentNumber)
            {
               if(Regex.IsMatch(part, "[a-zA-Z]"))
                {
                    result += part;                    
                }
            }

            result = Regex.Replace(result, "[0-9]", "/");
            result = result.Insert(3, "/").ToLower();
            Console.WriteLine($"All letters from document number (yyy/yyy/y/y): {result}");
        }

        /// <summary>
        /// Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void ShowLettersStringBuilder(string numberOfDocument)
        {
            string[] partsOfDocumentNumber = numberOfDocument.Split('-');
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Letters:{0}/{1}{2}", partsOfDocumentNumber[1].ToUpper(), partsOfDocumentNumber[3].ToUpper(), 
                Regex.Replace(partsOfDocumentNumber[4].ToUpper(), "[0-9]", "/")); 
           
            Console.WriteLine(result);
        }

        /// <summary>
        /// Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью).
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void FindSubstring(string numberOfDocument)
        {
            Regex regex = new Regex("abc", RegexOptions.IgnoreCase);
            
            if(regex.IsMatch(numberOfDocument))
            {
                Console.WriteLine("Document number contains substring \"abc\".");
            }
            else
            {
                Console.WriteLine("Document number does not contain substring \"abc\".");
            }
        }

        /// <summary>
        /// Проверить начинается ли номер документа с последовательности 555.
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void CheckFirstDigits(string numberOfDocument)
        {
            Regex regex = new Regex("^[5][5][5]");

            if (regex.IsMatch(numberOfDocument))
            {
                Console.WriteLine("Document number starts with 555.");
            }
            else
            {
                Console.WriteLine("Document number does not start with 555.");
            }
        }

        /// <summary>
        /// Проверить заканчивается ли номер документа на последовательность 1a2b.
        /// </summary>
        /// <param name="numberOfDocument"></param>
        public static void CheckLastSymbols(string numberOfDocument)
        {
            Regex regex = new Regex("[1][a][2][b]$", RegexOptions.IgnoreCase);

            if (regex.IsMatch(numberOfDocument))
            {
                Console.WriteLine("Document number ends with 1a2b.");
            }
            else
            {
                Console.WriteLine("Document number does not end with 1a2b.");
            }
        }
    }
}
