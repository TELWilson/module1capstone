using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Money
    {
        public Money()
        {

        }
        public decimal CurrentBalance { get; set; } = 0;

        public decimal AddMoney(decimal moneyAdd)
        {
            
            if(this.CurrentBalance + moneyAdd > 5000.00M)
            {
                return this.CurrentBalance;
            }
            return this.CurrentBalance += moneyAdd;
        }

        public decimal SubtractMoney (decimal moneyMinus)
        {
            return this.CurrentBalance -= moneyMinus;
        }
    }
}
