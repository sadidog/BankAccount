using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public string Name{ get; set;}
        private decimal balance;
        public Account  (string accountName, decimal initalBalance)
        {
            Name = accountName;
            balance = initalBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
        public void Withdraw(decimal withdrawAmount)
            {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine("you have insufficant funds"); //do i want to do this in the Account Class?  or Return to Main to Console.WriteLine? 
            }
            else if (withdrawAmount <= Balance)
            {
                Balance = Balance - withdrawAmount; 
            }
        }
     }  
 }