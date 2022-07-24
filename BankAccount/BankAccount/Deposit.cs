using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Deposit
    {
        // Create instance var
        double balance;

        // Create 2 constructors
        public Deposit()
        {
            balance = 100.00;

        } // End constructor Deposit

        public Deposit(double b)
        {
            balance = b;

        } // End second constructor Deposit

        public double calcBalance(double amt1, double amt2)
        {
            balance += amt1 + amt2;
            return balance;
        } // End calcBalance

        public double calcBalance(double amt1)
        {
            balance += amt1;
            return balance;
        } // End second calcBalance

    } // End class
} // End namespace
