using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string name;
        // method that sets the account name in the object
        public void SetName(string accountName)
        {
            name = accountName;
        }
        public string GetName()
        {
            return name; 
        }
    } 
}

