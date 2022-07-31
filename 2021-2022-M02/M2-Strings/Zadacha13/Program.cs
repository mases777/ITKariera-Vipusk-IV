using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);

            for (int i = 0; i < rows; i++)
            {
                double avg = 0;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0, 10}", matrix[i, j]);
                    avg += matrix[i, j];
                }
                avg /= cols;
                Console.WriteLine("{0, 10}", avg);
            }
            

        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
