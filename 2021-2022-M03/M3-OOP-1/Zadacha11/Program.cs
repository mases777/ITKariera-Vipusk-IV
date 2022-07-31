using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deposit 101 103.25
            //Withdraw 102 205.41
            //Print
            //Close
            var cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "Close")
            {
                int id;
                double amount;
                try
                {
                    switch (cmd[0])
                    {
                        case "Deposit":
                            id = int.Parse(cmd[1]);
                            amount = double.Parse(cmd[2]);
                            Bank.Deposit(id, amount);
                            break;
                        case "Withdraw":
                            id = int.Parse(cmd[1]);
                            amount = double.Parse(cmd[2]);
                            Bank.Withdraw(id, amount);
                            break;
                        case "Print":
                            Bank.Print();
                            break;                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
