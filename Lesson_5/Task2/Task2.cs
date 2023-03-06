namespace Lesson_5
{
    internal static class Task2
    {
        /// <summary>
        /// Создать класс CreditCard c полями номер счета, текущая сумма на счету.
        /// Добавьте метод, который позволяет начислять сумму на кредитную карточку.
        /// Добавьте метод, который позволяет снимать с карточки некоторую сумму.
        /// Добавьте метод, который выводит текущую информацию о карточке.
        /// Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма
        /// Тестовый сценарий для проверки:
        /// Положите деньги на первые две карточки и снимите с третьей.
        /// Выведите на экран текущее состояние всех трех карточек.
        /// </summary>
        public static void HWTask2()
        {
            CreditCard creditCard = new CreditCard("1234 5678 9101 1111", 1552.22);
            CreditCard creditCard2 = new CreditCard("1234 5678 9101 2222", 1852.22);
            CreditCard creditCard3 = new CreditCard("1234 5678 9101 3333", 6552.22);

            creditCard.AddAmountToBalance(150.85);
            creditCard2.AddAmountToBalance(900);
            creditCard3.GetAmountFromBalance(3252.99);

            creditCard.AddAmountToBalance(150.85);
            creditCard2.AddAmountToBalance(900);
            creditCard3.GetAmountFromBalance(3252.99);

            creditCard.ShowCardInfo();
            creditCard2.ShowCardInfo();
            creditCard3.ShowCardInfo();
        }
    }
}
