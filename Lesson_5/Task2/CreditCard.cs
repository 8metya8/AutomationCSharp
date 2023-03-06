using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class CreditCard
    {
        private string cardNumber;
        private double currentBalance;
        public string CardNumber 
        {
            get { return cardNumber; }
        }
        public double CurrentBalance 
        {
            get
            {
                return currentBalance;
            }
         
            set
            {
                if (value > 0)
                {
                    currentBalance = value;
                }
            }
        }

        public CreditCard(string cardNumber, double currentBalance = 0)
        {
            this.cardNumber = cardNumber;
            this.currentBalance = currentBalance;
        }

        public void ShowCardInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Card number - {CardNumber}, balance - {CurrentBalance:C2}");
        }

        public void AddAmountToBalance(double amount)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Add {amount} to {CurrentBalance:C2}");
            CurrentBalance = CurrentBalance + amount;            
            Console.WriteLine($"Current balance: {CurrentBalance:C2}");
        }

        public void GetAmountFromBalance(double amount)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Get {amount} from {CurrentBalance:C2}");

            if ((amount <= CurrentBalance))
            {
                CurrentBalance -= amount;
                Console.WriteLine($"Current balance: {CurrentBalance:C2}");
            }
            else
            {
                Console.WriteLine("Insufficient credit card balance.");
            }
        }
    }
}
