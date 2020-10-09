using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Money
    {
        private decimal moneyAdd;
        public Money()
        {
            this.MoneyAdd = moneyAdd;
        }
        public decimal CurrentBalance { get; set; } = 0;

        public decimal MoneyAdd { get; set; }
        

        public decimal AddMoney(decimal moneyAdd)
        {
            
            if(this.CurrentBalance + moneyAdd > 5000.00M || moneyAdd < 0.0M)
            {
                return this.CurrentBalance;
            }
            
            return this.CurrentBalance += moneyAdd;
        }

        public decimal SubtractMoney(decimal moneyMinus)
        {
            return this.CurrentBalance -= moneyMinus;
        }

        public string GiveChange()    // 20, 10, 5, 1, 25c, 10c, 5c 
        {
            int countOfTwenties = (int)this.CurrentBalance / 20;
            decimal remainingBalance = this.CurrentBalance % 20;

            int countOfTens = (int)remainingBalance / 10;
            remainingBalance = (remainingBalance % 10);

            int countOfFives = (int)remainingBalance / 5;
            remainingBalance = (remainingBalance % 5);

            int countOfOnes = (int)remainingBalance / 1;
            remainingBalance = (remainingBalance % 1);

            int countOfQuarters = ((int)(remainingBalance * 100)) / 25;
            remainingBalance = (remainingBalance % 0.25M);

            int countOfDimes = ((int)(remainingBalance * 100)) / 10;
            remainingBalance = (remainingBalance % 0.10M);

            int countOfNickels = ((int)(remainingBalance * 100)) / 5;
            remainingBalance = (remainingBalance % 0.05M);

            string giveChangeMessage = countOfTwenties + " Twenties " + countOfTens + " Tens " + countOfFives + " Fives " + countOfOnes + " Ones " +  countOfQuarters + " Quarters " + countOfDimes + " Dimes " + countOfNickels + " Nickels ";
            return giveChangeMessage;
        }
    }
}
