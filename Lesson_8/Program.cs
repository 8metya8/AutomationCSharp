namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task1.CreateAccount("login20symbolsssssss", "password", "password"));
            Console.WriteLine(Task1.CreateAccount("log in", "password", "password"));
            Console.WriteLine(Task1.CreateAccount("login", "pass word", "password"));
            Console.WriteLine(Task1.CreateAccount("login", "pass1word", "password"));
            Console.WriteLine(Task1.CreateAccount("login", "pass1word", "pass1word"));
        }
    }
}