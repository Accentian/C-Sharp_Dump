using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyOperatorOverloading
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money { 
            get 
            { 
                return money; 
            } 
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }
        
        // All overload MUST be public and static
        // Whenever there is a + operator for the implementation, this function executes
        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
        {
            double newAmountOfMoney = bank1.Money + bank2.Money;
            string newOwner = bank1.Owner + " + " + bank2.Owner;


            // Returns back to Program.cs
            BankAccount newBankAccount = new BankAccount(newAmountOfMoney, newOwner);
            return newBankAccount;

        }

        // All overload MUST be public and static
        // Overloading!
        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmountOfMoney = bank1.Money + amount;
            string newOwner = bank1.Owner;

            // Returns back to Program.cs
            BankAccount newBankAccount = new BankAccount(newAmountOfMoney, newOwner);
            return newBankAccount;

        }
    }
}
