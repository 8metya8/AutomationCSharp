namespace Lesson_5
{
    internal class Task3
    {
        /// <summary>
        /// Создать класс, описывающий банкомат.
        /// Набор купюр, находящихся в банкомате, должен задаваться тремя свойствами:
        /// количеством купюр номиналом 20, 50 и 100.
        /// Сделать метод для добавления денег в банкомат.
        /// Сделать метод, снимающуий деньги, который принимает сумму денег, а возвращает булевое значение - успешность выполнения операции.
        /// При снятии денег метод должен распечатывать каким количеством купюр какого номинала выдаётся сумма.
        /// Создать конструктор с тремя параметрами - количеством купюр каждого номинала.
        /// </summary>
        public static void HWTask3()
        {
            Console.WriteLine("\n----- Task 3 -----\n");
            
            ATM aTM = new ATM();
            aTM.AddBanknotes(50, 20, 10);
           
            bool iSRepeat = true;

            while (iSRepeat)
            {
                Console.Write("Enter integer amount for withdrowal (or EXIT for sign out ): ");
                string userAnswer = Console.ReadLine().Trim().ToUpper();

                switch (userAnswer)
                {
                    case "EXIT":
                        {
                            iSRepeat = false;
                            break;
                        }
                    default:
                        {
                            try
                            {
                                int amount = Convert.ToInt32(userAnswer);

                                if (aTM.Withdrowal(amount))
                                {
                                    Console.WriteLine("The transaction was successful.\n");
                                }
                                else
                                {
                                    Console.WriteLine("The transaction failed.\n");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Amount is not integer.\n");
                            }
                            break;
                        }
                }
            }                    
        }
    }
}
