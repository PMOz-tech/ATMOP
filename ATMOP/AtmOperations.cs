using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOP
{
    

    public delegate void Choice();

   public class AtmOperations
    {

        int balance = 200;
        public void ATMMenu()
        {
            Console.WriteLine("Please enter your choice selection");
            Console.WriteLine("Press 1. Withdraw \n 2. Check Balance \n 3. Transfer To Another Account");
            var input = Convert.ToInt32(Console.ReadLine());
            if(input == 1 )
            {
                Choice choice = ATMWithdrawals;
                choice();

            }
            else if (input == 2)
            {
                Choice choice = ATMCheckBalance;
                choice();
            }
            else if (input == 3)
            {
              
                Choice choice = ATMTransfer;
                choice();
            }
            else
            {
                Console.WriteLine("Please enter the correct syntax");
            }


        }

        public void ATMWithdrawals()
        {
            Console.WriteLine("Enter an amount to withdraw");
            var amt = Convert.ToInt32(Console.ReadLine());
            if(amt > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
               var balRemaining = balance - amt;
                Console.WriteLine($"Your balance after withdrawing is {balRemaining}");
            }
            


          
        }

        public void ATMCheckBalance()
        {
            var amount = balance;
            Console.WriteLine($"This your balance {amount}");
        }

        public void ATMTransfer()
        {
            Console.WriteLine("Please enter destination account number");
            var acc = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Enter the amount to transfer");
            var amt = Convert.ToInt32(Console.ReadLine());
            if(amt > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else 
            {
                var remBalance = balance - amt;
                Console.WriteLine($"Your balance after transfer is {remBalance}");
            }
            

        }
    }
}
