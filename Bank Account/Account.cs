using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
        public class Account : Client
    {
        //fields
      
        protected double cBalance;
        protected double sBalance;
        protected double cWithdrawal;
        protected double sWithdrawal;
        protected double cDeposit;
        protected double sDeposit;
                      

        public Account (double cBalance, double sBalance, double sWithdrawal, double cWithdrawal, double cDeposit, double sDeposit) 
        {
            //properties
         
            this.cBalance = 500.00d;
            this.sBalance = 2000.00d;
            this.cWithdrawal = cWithdrawal;
            this.sWithdrawal = sWithdrawal;
            this.cDeposit = cDeposit;
            this.sDeposit = sDeposit;          
        }

        //methods for withdrawal and deposit
        public virtual void CBalance()
        {
            cBalance = cBalance + cDeposit - cWithdrawal;
        }
        public virtual void SBalance()
        {
            sBalance = sBalance + sDeposit - sWithdrawal;
        }
                
    }
   
}
