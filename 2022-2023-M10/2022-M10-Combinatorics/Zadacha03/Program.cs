using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static List<int> currentSolution = new List<int>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Solve(n, 0);
        }

        private static void Solve(int n, int index)
        {
            if (n <= 0)
            {
                for (int i = 0; i < currentSolution.Count-1; i++)
                {
                    if (currentSolution[i] < currentSolution[i+1])
                    {
                        return;
                    }
                }
                Console.WriteLine(String.Join(" + ", currentSolution));
                return;
            }
            for (int i = n; i > 0; i--)
            {
                currentSolution.Add(i);
                Solve(n - i, index + 1);
                currentSolution.RemoveAt(index);
            }
        }
    }
}
