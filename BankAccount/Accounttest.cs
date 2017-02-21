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
            //Account myAccount = new Account();
            Account account1 = new Account("todd mochamer", 200.00m);
            Account account2 = new Account("steph mochamer",2000.00m);


            // display myAccount's inital name (there is not one yet) 
            //Console.WriteLine($"Inital name is: {myAccount.Name}");

            // prompt for and read the name, then put the name in the Account object
            //Console.Write("Enter the account name: ");
            //string theName = Console.ReadLine();
            ///myAccount.Name = theName;

            // display the name stored inthe myAccount object
            Console.WriteLine($"account1 name is: {account1.Name}");
            Console.WriteLine($"account2 name is: {account2.Name}");

            //display intal balance of each Account object
            Console.WriteLine($"the balance for {account1.Name} is {account1.Balance:C}");
            Console.WriteLine($"the balance for {account2.Name} is {account2.Balance:C}");

            // prompt for a deposit valuse input
            Console.Write($"Ener deposit ammount for {account1.Name}: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to {account1.Name}");

            account1.Deposit(depositAmount); //adds to balance using public method

            Console.WriteLine($"{account1.Name}'s Balance = {account1.Balance:C}");

            //prompt for a withdraw ammount
            Console.Write($"how much do you want to withdraw?");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            
            //subtrat from acount using method Withdraw
            account2.Withdraw(withdrawAmount);

            Console.WriteLine($"{account2.Name}'s Balance = {account2.Balance:C}");
            // lastline.
            Console.ReadLine();

        }
    }
}
