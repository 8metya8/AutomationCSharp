namespace Lesson_5
{
    internal class ATM
    {
        private int banknote20;
        private int banknote50;
        private int banknote100;

        public int Banknote20 { get; set; }
        public int Banknote50 { get; set; }
        public int Banknote100 { get; set; }

        public ATM(int banknote20 = 0, int banknote50 = 0, int banknote100 = 0)
        {
            this.banknote20 = banknote20;
            this.banknote50 = banknote50;
            this.banknote100 = banknote100;
        }

        public void AddBanknotes(int banknote20, int banknote50, int banknote100)
        {
            this.banknote20 += banknote20;
            this.banknote50 += banknote50;
            this.banknote100 += banknote100;

            Console.WriteLine($"Current count of banknotes:");
            Console.WriteLine($"banknote 20 - {banknote20}");
            Console.WriteLine($"banknote 50 - {banknote50}");
            Console.WriteLine($"banknote 100 - {banknote100}");
        }

        public bool Withdrowal(int amount)
        {
            int countOfBanknote20;
            int countOfBanknote50;
            int countOfBanknote100;

            if (amount <= (banknote20 * 20 + banknote50 * 50 + banknote100 * 100))
            {
                countOfBanknote100 = amount / 100;
                countOfBanknote100 = countOfBanknote100 > banknote100 ? banknote100 : countOfBanknote100;
                amount -= 100 * countOfBanknote100;

                countOfBanknote50 = amount / 50;
                countOfBanknote50 = countOfBanknote50 > banknote50 ? banknote50 : countOfBanknote50;
                amount -= 50 * countOfBanknote50;
               
                if( (amount > 0) && (amount < 20) && (countOfBanknote50 > 0))
                {
                    countOfBanknote50--;
                    amount += 50;
                }

                countOfBanknote20 = amount / 20;
                countOfBanknote20 = countOfBanknote20 > banknote20 ? banknote20 : countOfBanknote20;
                amount -= 20 * countOfBanknote20;

                if(amount == 0)
                {
                    Console.WriteLine("Amount has been withdrow via follow banknotes:");
                    Console.WriteLine($"Banknote 20: {countOfBanknote20}");
                    Console.WriteLine($"Banknote 50: {countOfBanknote50}");
                    Console.WriteLine($"Banknote 100: {countOfBanknote100}");

                    banknote100 -= countOfBanknote100;
                    banknote50 -= countOfBanknote50;
                    banknote20 -= countOfBanknote20;

                    return true;
              
                }               
            }
            else if( (banknote20 * 20 + banknote50 * 50 + banknote100 * 100) == 0)
            {
                Console.WriteLine("ATM ran out of money!");
            }

            return false;
        }
    }
}
