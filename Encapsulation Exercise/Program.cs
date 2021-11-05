using System;

namespace Encapsulation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBankAccount = new BankAccount();
            Console.WriteLine("Welcome to Chase Bank, and thanks for creating a new checkings account. How much money would you like to deposit in your account?");
            var amount = Convert.ToDouble(Console.ReadLine());
            myBankAccount.Deposit(amount);
            Console.WriteLine($"Thank you for depositing {amount} dollar(s) into your account");
            Console.WriteLine("Would you like to withdraw funds? y or n");
            var response = Console.ReadLine();
            if (response.ToLower() == "y" || response.ToLower() == "yes")
            {
                Console.WriteLine($"How much would you like to withdraw? Your current balance is {myBankAccount.GetBalance()}");
                var dollar = Convert.ToDouble(Console.ReadLine());
                if (dollar <= amount)
                {
                    myBankAccount.WithdrawBalance(dollar);
                    Console.WriteLine($"Your new balance is {myBankAccount.GetBalance()}");
                }
                else
                {
                    Console.WriteLine("Sorry, but the requested withdrawal amount exceeds available funds");
                }
            }
            else
            {
                Console.WriteLine("Have a great day!");
            }
        }
    }
}
