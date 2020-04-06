using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{
    class BankAccountB : IBankAccount
    {
        private string number;
        private string ownerName;
        private decimal balance;
        private bool bankAccountBVar;
        public string Number { get; }
        public string OwnerName { get; }
        public bool BankAccountBVar { get; }
        private static int accountNumberSeed = 1111;      
        public decimal Balance
        {
            get
            {               
                return balance;
            }
        }

        public string Description()
        {
            return "Obiekt klasy BankAccountB";
        }

        public BankAccountB()
        {
            this.Number = null;
            this.OwnerName = null;
        }

        public BankAccountB(string ownerName, decimal initialBalance, bool bankAccountBVar)
        {
            this.OwnerName = ownerName;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.bankAccountBVar = bankAccountBVar;

            this.balance = initialBalance;
        }        
    }
}
