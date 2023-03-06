namespace Lesson_5
{
    internal class Therapist
    {
        string type = "Therapist";
        public string Type { get { return type; } }

        public Therapist()
        {

        }
        public void Treat()
        {
            Console.WriteLine("Treating: Examination and medical tests.\n");
        }
    }
}
