using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Saving : Account
                
         
    {
        //public double SBalance = 2000.00d;

        public void SBalanceIncrease() 
        {
            this.sBalance = sBalance + sDeposit;
        }

        public void SBalanceDecrease()
        {
            this.sBalance = sBalance - sWithdrawal;
        }

        




    }
}
