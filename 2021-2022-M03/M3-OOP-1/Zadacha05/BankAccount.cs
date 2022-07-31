using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
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

        public BankAccount() : this(0, 0)
        {

        }
        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
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

        public override string ToString()
        {
            return $"Account ID{id}, balance {balance:f2}";
        }

        //public void Print()
        //{
        //    Console.WriteLine($"Account ID{id}, balance {balance:f2}");
        //}
    }
}
