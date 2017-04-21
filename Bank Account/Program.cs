using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("Welcome to Cash Money Bank online banking website. Please answer the following questions to log in.");
            Console.WriteLine("What is you first and last name?");
            string fullName = Console.ReadLine();
            Console.WriteLine("What is the full address listed on your account?");
            string address = Console.ReadLine();
            Console.WriteLine("What is the phone number on your account?");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(fullName + ", you have successfully logged in! Please select and option below.");

            int selectedOption;


            do
            {
                Console.WriteLine();                
                Console.WriteLine();
                Console.WriteLine("1.View Client Information");
                Console.WriteLine("2.View Account Balance");
                Console.WriteLine("3.Deposit Funds");
                Console.WriteLine("4.Withdraw Funds");
                Console.WriteLine("5.Exit");
                Console.WriteLine();
                Console.WriteLine();
                selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Client Name: " + fullName);
                        Console.WriteLine("Checking Acct Number: 891");
                        Console.WriteLine("Savings Acct Number: 341");
                        Console.WriteLine("Address: " + address);
                        Console.WriteLine("Phone Number: " + phoneNumber);
                        break;

                    case 2:
                        //I couldnt pull the balance over
                        Console.WriteLine("Checking: "  + "cBalance" + "Saving: " + "sBalance");
                        break;
                       
                    case 3:
                        Console.WriteLine("Please selcect a or b. \na.Checking Account \nb.Savings Account");
                        if (selectedOption == 'a')
                        {
                            Console.WriteLine("How much would you like to deposit into Checking?");
                            double cDeposit = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your deposit for " + cDeposit + "is complete.");                           
                        }

                        else if (selectedOption == 'b')
                        {
                            Console.WriteLine("How much would you like to deposit into Saving?");
                            double sDeposit = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your deposit for " + sDeposit + "is complete.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry please try again.");
                        }
                        break;
                        

                    case 4:
                        Console.WriteLine("How much would you like to withdrawal");
                        double withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your withdrawal for " + withdrawal + "is complete");
                        break;
                                      
                    case 5:
                        Console.WriteLine("Thank you for banking with Cash Money Bank. Press any key to completely log out.");
                            break;                                                
                }
            } while (selectedOption != 5);
            //Im trying to give this a minimum of 100 dollars in the savings account.
            //if (sBalance < 100.00)
            //{
            //    Console.WriteLine("Your balance cannot go below $100.00. Please visit you local branch for further assistace and press 5 to exit.");
            //}                       
            
        }
    }
}
