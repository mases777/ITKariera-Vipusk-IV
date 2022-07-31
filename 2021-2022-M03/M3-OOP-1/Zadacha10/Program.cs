using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"People = {Person.Counter()}");
            Person ivan = new Person("Ivan", 12);
            Console.WriteLine($"People = {Person.Counter()}");
            Person pesho = new Person("Pesho", 18);
            Console.WriteLine($"People = {Person.Counter()}");            
           
        }
    }
}
