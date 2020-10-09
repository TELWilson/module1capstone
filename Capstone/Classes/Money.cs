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
            return this.CurrentBalance += moneyAdd;
        }

        public decimal SubtractMoney (decimal moneyMinus)
        {
            return this.CurrentBalance -= moneyMinus;
        }
    }
}
