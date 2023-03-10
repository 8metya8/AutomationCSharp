namespace Lesson_6
{
    internal class Doctor
    {
        public string typeOfDoctor;

        public Doctor(string typeOfDoctor) 
        {
            this.typeOfDoctor = typeOfDoctor;
        }

        public virtual void Treat()
        {
            Console.WriteLine("Default doctor.");
        }
    }
}
