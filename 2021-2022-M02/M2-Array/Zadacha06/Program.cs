﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
