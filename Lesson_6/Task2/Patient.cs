namespace Lesson_6
{
    internal class Patient
    {
        string name;
        TreatmentPlan treatmentPlan;
        Doctor doctor;

        public string Name { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }
        public object Doctor { get; }

        public Patient(string name, TreatmentPlan treatmentPlan)
        {
            this.name = name;
            this.treatmentPlan = treatmentPlan;
        }

        public void AddDoctor()
        {
            switch (this.treatmentPlan.Code)
            {
                case 1:
                    {
                        this.doctor = new Surgeon("Surgeon");
                        Console.WriteLine($"{doctor.typeOfDoctor} has been added to {name}");
                        this.doctor.Treat();
                        break;
                    }
                case 2:
                    {
                        this.doctor = new Dentist("Dentist");
                        Console.WriteLine($"{doctor.typeOfDoctor} has been added to {name}");
                        this.doctor.Treat();
                        break;
                    }
                default:
                    {
                        this.doctor = new Therapist("Therapist");
                        Console.WriteLine($"{doctor.typeOfDoctor} has been added to {name}");
                        this.doctor.Treat();
                        break;
                    }
            }
        }
    }
}
