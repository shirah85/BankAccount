using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
   public class Checking : Account

    {    
        //Im not sure why the checking and savings class is not corresponding with cbalance and sBalance.     
        public double CBalance = 500.00d;

        public void CBalanceIncrease()
        {
            this.cBalance = cBalance + cDeposit;
        }

        public void CBalanceDecrease()
        {
            this.cBalance = cBalance - cWithdrawal;
        }
        Client myBalance = new Client();
    }
}
