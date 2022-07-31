using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha11
{
    class Bank
    {
        private static List<BankAccount> accounts;
        static Bank()
        {
            accounts = new List<BankAccount>();
        }

        public static void Deposit(int id, double amount)
        {
            var account = accounts.Where(x => x.ID == id).FirstOrDefault();
            if (account == null)
            {
                accounts.Add(new BankAccount(id, amount));
            }
            else
            {
                accounts.Where(x => x.ID == id).First().Deposit(amount);
            }
        }
        public static void Withdraw(int id, double amount)
        {
            var account = accounts.Where(x => x.ID == id).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentException("Bank account does not exist.");
            }
            else
            {
                accounts.Where(x => x.ID == id).First().Withdraw(amount);
            }
        }
        public static void Print()
        {
            accounts.ForEach(x => Console.WriteLine(x));
        }
    }
}
