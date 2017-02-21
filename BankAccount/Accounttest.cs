using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class AccountTest
    {
        static void Main()
        {
            // create an Account object and assign it to myAccount
            Account myAccount = new Account();

            // display myAccount's inital name (there is not one yet) 
            Console.WriteLine($"Inital name is: {myAccount.GetName()}");

            // prompt for and read the name, then put the name in the Account object
            Console.Write("Enter the account name: ");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);

            // display the name stored inthe myAccount object
            Console.WriteLine($"MyAccount's name is: {myAccount.GetName()}");
        }
    }
}
