using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);

            int maxRow = 0, maxCol = 0;
            int maxSum = matrix[maxRow, maxCol];
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    var tempSum = matrix[i, j] +
                                  matrix[i, j + 1] +
                                  matrix[i + 1, j] +
                                  matrix[i + 1, j + 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            //Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
            //Console.WriteLine(matrix[maxRow + 1, maxCol] + " " + matrix[maxRow + 1, maxCol + 1]);

            Console.WriteLine
                (
                     "{0} {1}\n{2} {3}",
                     matrix[maxRow, maxCol],
                     matrix[maxRow, maxCol + 1],
                     matrix[maxRow + 1, maxCol],
                     matrix[maxRow + 1, maxCol + 1]
                );

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
