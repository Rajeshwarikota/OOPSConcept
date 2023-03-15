using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Encapsulation
{
     class Bank
    {
        public string Name;
        private int AccountNumber;
        private double Balance;

        public void SetAccountNumber(int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
        }
        public void SetBalance(double Balance)
        {
            this.Balance = Balance;
        }

    }
}
