namespace Lesson_6
{
    internal class TreatmentPlan
    {
        int code;
        string description;

        public int Code
        {
            get { return code; }
        }

        public string Description
        {
            get { return description; }
        }

        public TreatmentPlan(int code = 3, string description = "Take a blood test.")
        {
            this.code = code;
            this.description = description;
        }
    }
}
