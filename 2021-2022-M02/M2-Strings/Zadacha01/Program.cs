using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            //string proba = Console.ReadLine();
            //for (int i = 0; i < proba.Length; i++)
            //{
            //    Console.WriteLine(proba[i]);
            //}
            //Console.WriteLine(proba);

            //string duma = "Tova e proba";
            //char bukva = duma[3];
            //bukva = 'd';
            //Console.WriteLine(bukva);

            //string str = new String(new char[] { 's', 't', 'r' });
            //Console.WriteLine(str);
            //char[] charArr = str.ToCharArray(); // ['s', 't', 'r']
            //Console.WriteLine(string.Join(" ", charArr));

            //var timer = new Stopwatch();
            //timer.Start();
            //string result = "";
            //for (int i = 0; i < 50000; i++)
            //    result += Convert.ToString(i, 2);
            //Console.WriteLine(result.Length);
            //Console.WriteLine(timer.Elapsed);


            var timer = new Stopwatch();
            timer.Start();
            var result = new StringBuilder();
            for (int i = 0; i < 50000; i++)
                result.Append(Convert.ToString(i, 2));
            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed);
        }
    }
}
