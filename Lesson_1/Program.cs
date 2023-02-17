namespace Lesson_1;
class HelloWorld
{
    static void Main(string[] args)
    {
        string username;

        Console.Write("Please, enter username and press Enter: ");
        username = Console.ReadLine();

        Console.WriteLine($"Hello, {username}!");
    }
}