using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{
    class BankAccountA : IBankAccount, IBankAccountOperations
    {
        private string number;
        private string ownerName;
        private decimal balance;
        private char bankAccountAVar;
        public string Number { get; }
        public string OwnerName { get; }
        public char BankAccountAVar;
        private static int accountNumberSeed = 1111;
        private List<Transaction> allTransactions = new List<Transaction>();
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction item in allTransactions)
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
            foreach (Transaction item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date}\t{item.Amount}\t{balance}\t{item.Note}");
            }
            return report.ToString();
        }

        public string Description()
        {
            return "Obiekt klasy BankAccountA";
        }

        public BankAccountA()
        {
            this.Number = null;
            this.OwnerName = null;
        }

        public BankAccountA(string ownerName, decimal initialBalance, char bankAccountAVar)
        {
            this.OwnerName = ownerName;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.bankAccountAVar = bankAccountAVar;

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
    }
}
