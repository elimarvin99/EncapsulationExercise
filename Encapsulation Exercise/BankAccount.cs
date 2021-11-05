using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Exercise
{
    class BankAccount
    {
        public BankAccount() //default constructor
        {

        }
        private double Balance;
        public BankAccount(double amount)
        {
            Balance = amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void WithdrawBalance(double amount)
        {
            Balance -= amount;
        }

    }
}
