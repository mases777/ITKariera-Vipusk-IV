using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();

            //var output = Convert.ToInt32(input, 16);

            //Console.WriteLine(output);

            //int dec = int.Parse(Console.ReadLine());

            //var hex = Convert.ToString(dec, 16).ToUpper();
            //var bin = Convert.ToString(dec, 2);

            //Console.WriteLine(hex);
            //Console.WriteLine(bin);

            //Console.WriteLine(100000000000000.0 + 0.3);
            //// Result: 100000000000000 (загуба на точност)
            //double a = 1.0f, b = 0.33f, sum = 1.33;
            //Console.WriteLine("a+b={0} sum={1} equal={2}",
            //  a + b, sum, (a + b == sum));
            //// a+b=1.33000001311302 sum=1.33 equal=False
            //double one = 0;
            //for (int i = 0; i < 10000; i++) one += 0.0001;
            //Console.WriteLine(one); // 0.999999999999906


            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
                sum += decimal.Parse(Console.ReadLine());
            Console.WriteLine(sum);



        }
    }
}
