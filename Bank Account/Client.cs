using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    //properties
    public class Client 
    {
        private string fullName;
        private string address;
        private string phoneNumber;
        private string checkAcctNumber;
        private string savAcctNumber;

        //constructors
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.fullName = value; }
        }

        public string PhoneNumber
        {
            get { return this.address; }
            set { this.fullName = value; }
        }

        public Client()
        {
            this.checkAcctNumber = "891";
            this.savAcctNumber = "341";
        }

        public Client(string fullName, string address, string phoneNumber, string checkAcctNumber, string savAcctNumber)
        {
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.checkAcctNumber = checkAcctNumber;
            this.savAcctNumber = savAcctNumber;
        }

        //Method for Client Info
        public void ClientInfo()
        {
            Console.WriteLine("Client Name: " + fullName);
            Console.WriteLine("Checking Acct Number: " + checkAcctNumber);
            Console.WriteLine("Savings Acct Number: " + savAcctNumber);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone Number: " + phoneNumber);
        }
    }
}
