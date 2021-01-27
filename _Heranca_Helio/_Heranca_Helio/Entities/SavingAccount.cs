using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Heranca_Helio.Entities
{
     class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount (int number, string holder, double balance, double interestRate) :base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //com selead nao pode ser herdada ou feito a sobrecarga
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
