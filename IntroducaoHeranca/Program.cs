using IntroducaoHeranca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroducaoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //UPCASTING

            Account acc2 = bacc;
            Account acc3 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc4 = new SavingsAccount(1004, "Anna", 0, 0.01);

            //DOWNCASTING

            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(100);
            //BusinessAccount acc6 = (BusinessAccount)acc4; -> Não é possivel converter uma Saving para Business

            if (acc4 is BusinessAccount)
            {
                //BusinessAccount acc6 = (BusinessAccount)acc4;
                BusinessAccount acc6 = acc4 as BusinessAccount;
                acc6.Loan(200);
                Console.WriteLine("Loan!");
            }
            if(acc4 is SavingsAccount)
            {
                //SavingsAccount acc6 = (SavingsAccount)acc4;
                SavingsAccount acc6 = acc4 as SavingsAccount;
                acc6.UpdateBalance();
                Console.WriteLine("Update");
            }

            acc4.Deposit(1000);
            acc4.Withdraw(500);
            Console.WriteLine(acc4.Balance);

            acc2.Deposit(1000);
            acc2.Withdraw(500);
            Console.WriteLine(acc2.Balance);

            Console.ReadLine();
        }
    }
}
