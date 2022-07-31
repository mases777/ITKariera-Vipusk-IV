using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha11
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int iD, double balance)
        {
            this.ID = iD;
            this.Balance = balance;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance || amount < 0)
                throw new ArgumentException("Insufficient balance");
            balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{id}, balance {balance:f2}";
        }
    }
}
