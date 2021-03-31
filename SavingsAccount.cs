using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class SavingsAccount:Account
    {
        public SavingsAccount(String owner) : base(owner)
        {

        }
        

        public void calculateInterest(int amount, double rate)
        {
           if(rate<1)
            base.addBalance((int)((int)amount * rate));

        }
    }
}
