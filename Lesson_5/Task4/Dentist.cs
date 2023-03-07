namespace Lesson_5
{
    internal class Dentist
    {
        string type = "Dentist";
        public string Type { get { return type; } }

        public Dentist()
        {

        }
        public void Treat()
        {
            Console.WriteLine("Treating: tooth brushing and treatment.\n");
        }
    }
}
