namespace Lesson_6
{
    internal class Dentist : Doctor
    {
        public Dentist(string typeOfDoctor) : base(typeOfDoctor)
        {

        }

        public override void Treat()
        {
            Console.WriteLine($"Doctor is {this.typeOfDoctor}. Treating: tooth brushing and treatment.\n");
        }
    }
}
