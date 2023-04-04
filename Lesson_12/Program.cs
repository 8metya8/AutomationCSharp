using System.Collections.Generic;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "word", "q", "ee", "333", "23", "deer", "w", "qwerty", "asd3fgh", "q", "333"};

            Console.WriteLine($"Word with lenght 1 symbol - {GetFirstShortWord(words)}");
            Console.WriteLine($"\nLast word with \"ee\" - {GetLastShortWord(words)}");
            Console.WriteLine($"\nLast word with condition (length >= min and length <= max) - {GetLastWordWithCondition(words, 3, 6)}");
            Console.WriteLine($"\nCount of unique elements - {GetCountUniqueValues(words)}, Length of array - {words.Length}");

            Console.Write("\nArray of words that contains \"3\" : ");
            var list = GetElements(words);
            foreach(var word in list)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"\nLength of the shortest word - {GetLengthOfShortestWord(words)}");

            Console.WriteLine("\nReverse dictionary: ");
            IDictionary<int, string> dictionary = new Dictionary<int, string>() {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" }
            };

            IEnumerable<(string Key, int Value)> newDictionary = DictionaryToList(dictionary);

            foreach(var pair in newDictionary)
            {
                Console.WriteLine($"Key - {pair.Key}, value - {pair.Value}");
            }

            User user1 = new User("Vasiliy", "Petrovich", "Gorbunkov");
            User user2 = new User("Sergei", "", "Kikabidze");
            User user3 = new User("Andrei", "", "Andreev");            

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            Console.WriteLine($"\nGet full name:");
            foreach (var user in users)
            {
                Console.WriteLine(GetFullName(user));
            }

            Console.WriteLine("\nSort by LastName: ");
            foreach(var user in SortUserByLastName(users))
            {
                Console.WriteLine(GetFullName(user));
            }
        }

        /// <summary>
        /// Метод возвращает первое слово из последовательности слов, содержащее только одну букву.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string? GetFirstShortWord(string[] words)
        {
            return words.FirstOrDefault(word => word.Length == 1);
        }

        /// <summary>
        /// Метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string? GetLastShortWord(string[] words)
        {
            return words.LastOrDefault(word => word.Contains("ee"));
        }

        /// <summary>
        /// Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max. 
        /// Если нет слов, соответствующих условию, метод возвращает null.
        /// </summary>
        /// <returns></returns>
        public static string? GetLastWordWithCondition(string[] words, int minLenght, int maxLenght)
        {
            return words.LastOrDefault(word => (word.Length >= minLenght) && (word.Length <= maxLenght));
        }

        /// <summary>
        /// Напишите метод, который возвращает количество уникальных значений в массиве.
        /// </summary>
        /// <returns></returns>
        public static int GetCountUniqueValues(string[] words)
        {
            return words.Distinct().Count();
        }

        /// <summary>
        /// Напишите метод, который принимает список и извлекает значения с 5 элемента (включительно)  те значение которые содержат 3.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetElements(IList<string> words)
        {
            return words.Skip(4).Where(word => word.Contains("3"));
        }

        /// <summary>
        /// Метод возвращает длину самого короткого слова.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int GetLengthOfShortestWord(string[] words)
        {

            return words.OrderBy(word => word.Length).First().Length;
        }

        /// <summary>
        /// Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение.
        /// </summary>
        public static IEnumerable<(string Key, int Value)> DictionaryToList(IDictionary<int, string> dictionary)
        {
           return from value in dictionary
                  select (value.Value, value.Key);
        }

        /// <summary>
        /// Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string GetFullName(User user)
        {
            return string.IsNullOrEmpty(user.MiddleName) ? user.FirstName + " " + user.LastName : user.FirstName + " " + user.MiddleName + " " + user.LastName;
        }

        /// <summary>
        /// Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static IEnumerable<User> SortUserByLastName(List<User> users)
        {
            return users.OrderBy(user => user.LastName);
        }
    }  
}