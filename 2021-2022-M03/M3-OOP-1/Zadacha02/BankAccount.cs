using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class BankAccount
    {
        private int id;
        private double balance;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance || amount < 0)
                Console.WriteLine("Insufficient balance");
            else
                balance -= amount;
        }

        public void Print()
        {
            Console.WriteLine($"Account ID{id}, balance {balance:f2}");
        }
    }
}
