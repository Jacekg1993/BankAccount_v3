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
            BankAccountA UserBankA = new BankAccountA("Jacek", 10000, 'A');
            BankAccountB UserBankB = new BankAccountB("Szymon", 15000, true);

            Console.WriteLine(UserBankA.Description());
            Console.WriteLine(UserBankA.Balance);

            Console.WriteLine(UserBankB.Description());
            Console.WriteLine(UserBankB.Balance);
           
            UserBankA.MakeDeposit(1000, DateTime.Now, "jakas wplata");
            UserBankA.MakeWithdrawal(3000, DateTime.Now, "jakas wyplata");
 
            Console.WriteLine("________________");
            Console.WriteLine(UserBankA.GetAccountHistory());


            Console.ReadKey();
        }
    }
}
