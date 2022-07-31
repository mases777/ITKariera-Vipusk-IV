using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetics.Add(10, 15));

            Person firstPerson = new Person();
            firstPerson.Name = "Ivan";
            firstPerson.Age = 12;
            firstPerson.IntroduceYourself();
            firstPerson.Accounts = new List<BankAccount>()
            {
                new BankAccount() {ID = 1, Balance = 1000},
                new BankAccount() {ID = 2, Balance = 2500},
                new BankAccount() {ID = 3, Balance = 3700}
            };
            Console.WriteLine($"Balance = {firstPerson.GetBalance()}");

            Person secondPerson = new Person();
            secondPerson.Name = Console.ReadLine();
            secondPerson.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            secondPerson.IntroduceYourself();

            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
