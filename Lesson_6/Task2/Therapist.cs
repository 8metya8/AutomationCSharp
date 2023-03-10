namespace Lesson_6
{
    internal class Therapist : Doctor
    {
        public Therapist(string typeOfDoctor) : base(typeOfDoctor)
        {
        }

        public override void Treat()
        {
            Console.WriteLine($"Doctor is {this.typeOfDoctor}. Treating: Examination and medical tests.\n");
        }
    }
}
