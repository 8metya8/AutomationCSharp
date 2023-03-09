namespace Lesson_6
{
    /// <summary>
    /// Создать программу для имитации работы клиники.  
    /// Пусть в клинике будет три врача: хирург, терапевт и дантист.
    /// Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.Так же предусмотреть класс «Пациент» и класс «План лечения».  
    /// Создать объект класса «Пациент» и добавить пациенту план лечения.Так же создать метод, который будет назначать врача пациенту согласно плану лечения.
    /// Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить.
    /// Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить.  
    /// Если план лечения имеет любой другой код – назначить терапевта и выполнить метод лечить. 
    /// </summary>
    internal static class Task2
    {
        internal static void HWTask2()
        {
            Console.WriteLine("\n----- Task 2 -----\n");

            Patient patient = new Patient("Vasya", new TreatmentPlan(1, "Remove the kidney stones."));
            patient.AddDoctor();

            Patient patient2 = new Patient("Andrei", new TreatmentPlan(2, "Cure a tooth."));
            patient2.AddDoctor();

            Patient patient3 = new Patient("Olga", new TreatmentPlan(3));
            patient3.AddDoctor();
        }
    }
}
