namespace Lesson_5
{
    internal class Surgeon
    {
        string type = "Surgeon";
        public string Type { get { return type; } }

        public Surgeon()
        {

        }
        public void Treat()
        {
            Console.WriteLine("Treating: Elective surgery.\n");
        }
    }
}
