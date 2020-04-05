using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountV3
{
    class BankAccountA : BankAccount
    {
        public char BankATestVariable { get; }

        public override string Description()
        {
            return "Bank account A";
        }

        public BankAccountA() : base()
        {

        }

        public BankAccountA(string ownerName, decimal initialBalance, char bankATestVariable) : base(ownerName, initialBalance)
        {
            this.BankATestVariable = bankATestVariable;
        }
    }
}
