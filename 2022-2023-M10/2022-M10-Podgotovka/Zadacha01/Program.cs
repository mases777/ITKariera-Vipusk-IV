using System;
using System.Collections.Generic;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coins = { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 50, 50, 50, 20, 20, 20, 10, 10, 10, 5, 5, 5, 2, 2, 2, 1, 1, 1 };
            int finalSum = n;
            int currentSum = 0;
            int br = 0;

            Queue<int> resultCoins = new Queue<int>();

            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum)
                {
                    continue;
                }
                currentSum += coins[i];
                br++;
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                {
                    Console.WriteLine(br);
                    return;
                }
            }
        }
    }
}
