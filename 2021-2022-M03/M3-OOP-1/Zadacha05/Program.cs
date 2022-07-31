using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            //BankAccount bank1 = new BankAccount();
            //bank1.ID = 1;

            accounts.Add(new BankAccount(1, 25.23));
            accounts.Add(new BankAccount(2, 125.04));
            accounts.Add(new BankAccount(3, 4.01));

            Person ivan = new Person("Ivan", 23, accounts);

            Console.WriteLine(ivan.GetBalance());
        }
    }
}
