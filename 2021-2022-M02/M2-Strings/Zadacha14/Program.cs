using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);

            int[] min = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                min[j] = matrix[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < min[j])
                        min[j] = matrix[i, j];
                }
            }

            PrintMatrix(rows, cols, matrix);

            for (int i = 0; i < cols; i++)
            {
                Console.Write("{0,5}", min[i]);
            }
            Console.WriteLine();

        }

        private static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
        }
    }
}
