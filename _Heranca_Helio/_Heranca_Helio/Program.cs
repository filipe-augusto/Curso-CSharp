using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Heranca_Helio.Entities;

namespace _Heranca_Helio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region upcasting e downcasting
            //BusinessAcount account = new BusinessAcount(8010, "bob brown", 100.00, 500.00);
            //Console.WriteLine(account.Balance);
            //BusinessAcount bacc = new BusinessAcount(1002, "maria", 0.0, 500.0);

            //// account.Balance = 200.0; //devido ao protected nao é possivel alterar somente em uma subclasse


            ////UPCASGTING 
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAcount(1003, "Bob ", 0.0, 200.0);
            //Account acc3 = new SavingAccount(1004,"Anna", 0.0, 0.01);

            ////DOWNCASTING
            //BusinessAcount acc4 = (BusinessAcount)acc2;
            //acc4.Loan(100.0);
            //// acc2.Loan(200);
            ////BusinessAcount acc5 = (BusinessAcount)acc3;

            //if(acc3 is BusinessAcount)
            //{
            //    BusinessAcount acc5 = (BusinessAcount)acc3;
            //    acc5.Loan(200);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingAccount)
            //{
            //  //  SavingAccount acc5 = (SavingAccount)acc3;
            //  //  acc5.
            //}
            #endregion
            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);
            List<Account> list = new List<Account>();
            list.Add(new SavingAccount(1001, "alex", 500, 0.01));
            list.Add(new BusinessAcount(1002, "Maria", 500, 400));
            list.Add(new SavingAccount(1001, "alex", 500, 0.01));
            list.Add(new BusinessAcount(1001, "alex", 500, 0.01));

            double sum = 0.03;
            foreach (Account acc in list){
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2"));
            //acc1.Withdraw(10);

            foreach(Account acc in list)
            {
                acc.Withdraw(10);
            }

            foreach(Account acc in list){
                Console.WriteLine("updated balance for account" +
                    acc.Number
                    + " : "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();


        }
    }
}
