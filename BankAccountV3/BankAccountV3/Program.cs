using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount UserBankA = new BankAccountA("Jacek", 10000, 'A');
            Console.WriteLine(UserBankA.Description());
            Console.WriteLine(UserBankA.Balance);

            UserBankA.MakeDeposit(1000, DateTime.Now, "wplata");
            UserBankA.MakeWithdrawal(3000, DateTime.Now, "wyplata");

            Console.WriteLine(UserBankA.Balance);

            Console.WriteLine(UserBankA.GetAccountHistory());

            Console.ReadKey();
        }
    }
}
