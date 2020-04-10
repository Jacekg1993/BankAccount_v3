using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{
    abstract class BankAccount
    {
        public string Number { get; }
        private OwnerName UserName;
        private static int accountNumberSeed = 1111;
        private List<Transaction> allTransactions = new List<Transaction>();
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(Transaction item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Transaction deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            Transaction withdrawal = new Transaction(amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            StringBuilder report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\tAmount\tBalance\tNote");
            foreach(Transaction item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date}\t{item.Amount}\t{balance}\t{item.Note}");
            }
            return report.ToString();
        }

        public abstract string Description();

        public BankAccount()
        {
            this.Number = null;
            this.UserName = null;
        }

        public BankAccount(string ownerName, decimal initialBalance)
        {
            Console.WriteLine("Przed");
            this.UserName = new OwnerName(ownerName, initialBalance);
            Console.WriteLine("Po");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial deposit");
        }

        private class Transaction
        {
            public decimal Amount { get; }
            public DateTime Date { get; }
            public string Note { get; }

            public Transaction(decimal amount, DateTime date, string note)
            {
                this.Amount = amount;
                this.Date = date;
                this.Note = note;
            }
        }

        public string GetName()
        {
            return UserName[0];
        }

        public string GetSurname()
        {
            return UserName[1];
        }

        public string GetFullName()
        {
            return UserName[0] + " " + UserName[1];
        }

        private class OwnerName
        {
            private string[] ownerName;
            private decimal testVariable;


            public OwnerName(string name, decimal testVar)
            {
                this.ownerName = name.Split();
                this.testVariable = testVar;
                Console.WriteLine("Utworzono: " + ownerName[0]);
            }

            public decimal test2()
            {
                return testVariable;
            }

            public string this[int n]
            {
                get
                {
                    if (ownerName.Length > n)
                    {
                        return ownerName[n];
                    }
                    return null;
                }
                set
                {
                    if (ownerName.Length > n)
                    {
                        ownerName[n] = value;
                    }
                }
            }
        }
    }
}
