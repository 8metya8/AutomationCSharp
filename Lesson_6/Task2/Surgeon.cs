namespace Lesson_6
{
    internal class Surgeon : Doctor
    {
        public Surgeon(string typeOfDoctor) : base(typeOfDoctor)
        {
        }

        public override void Treat()
        {
            Console.WriteLine($"Doctor is {this.typeOfDoctor}. Treating: Elective surgery.\n");
        }
    }
}
