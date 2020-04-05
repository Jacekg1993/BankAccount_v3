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


            Console.ReadKey();
        }
    }
}
