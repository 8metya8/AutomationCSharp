namespace Lesson_5
{
    internal class Patient
    {
        string name;
        TreatmentPlan treatmentPlan;
        object doctor;

        public string Name { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }
        public object Doctor { get;}

        public Patient(string name, TreatmentPlan treatmentPlan)
        {
            this.name = name;
            this.treatmentPlan = treatmentPlan;
        }

        public void AddDoctor()
        {
            switch(this.treatmentPlan.Code)
            {
                case 1:
                    {
                        this.doctor = new Surgeon();
                        Console.WriteLine($"{((Surgeon)this.doctor).Type} has been added to {name}");
                        ((Surgeon)this.doctor).Treat();
                        break;
                    }
                case 2:
                    {
                        this.doctor = new Dentist();
                        Console.WriteLine($"{((Dentist)this.doctor).Type} has been added to {name}");
                        ((Dentist)this.doctor).Treat();
                        break;
                    }
                default:
                    {
                        this.doctor = new Therapist();
                        Console.WriteLine($"{((Therapist)this.doctor).Type} has been added to {name}");
                        ((Therapist)this.doctor).Treat();
                        break;
                    }
            }
        }
    }
}
