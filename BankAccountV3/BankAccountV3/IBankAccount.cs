using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{   
    interface IBankAccount
    {
        decimal Balance
        {
            get;
        }

        string OwnerName { get; }

        void MakeDeposit(decimal amount, DateTime date, string note);
        void MakeWithdrawal(decimal amount, DateTime date, string note);
        string GetAccountHistory();
        public string Description();
    }
}
