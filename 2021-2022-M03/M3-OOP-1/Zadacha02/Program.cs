using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var command = line.Split().ToArray();
                switch (command[0])
                {
                    case "Create":
                        {
                            Create(command, accounts);
                            break;
                        }

                    case "Deposit":
                        {
                            Deposit(command, accounts);
                            break;
                        }

                    case "Withdraw":
                        {
                            Withdraw(command, accounts);
                            break;
                        }

                    case "Print":
                        {
                            Print(command, accounts);
                            break;
                        }
                }
            }
        }

        private static void Print(string[] command, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(command[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Print();
            }
        }

        private static void Withdraw(string[] command, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(command[1]);
            var balance = double.Parse(command[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Withdraw(balance);
            }
        }

        private static void Deposit(string[] command, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(command[1]);
            var balance = double.Parse(command[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(balance);
            }
        }

        private static void Create(string[] command, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(command[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                accounts[id] = new BankAccount();
            }
        }
    }
}
