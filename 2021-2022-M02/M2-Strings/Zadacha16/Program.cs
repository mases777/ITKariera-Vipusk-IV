using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 3, cols = 3;
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            bool xWin =
                (
                    (matrix[0, 0] == 'X' && matrix[1, 1] == 'X' && matrix[2, 2] == 'X') ||
                    (matrix[0, 2] == 'X' && matrix[1, 1] == 'X' && matrix[2, 0] == 'X') ||
                    (matrix[0, 0] == 'X' && matrix[0, 1] == 'X' && matrix[0, 2] == 'X') ||
                    (matrix[1, 0] == 'X' && matrix[1, 1] == 'X' && matrix[1, 2] == 'X') ||
                    (matrix[2, 0] == 'X' && matrix[2, 1] == 'X' && matrix[2, 2] == 'X') ||
                    (matrix[0, 0] == 'X' && matrix[1, 0] == 'X' && matrix[2, 0] == 'X') ||
                    (matrix[0, 1] == 'X' && matrix[1, 1] == 'X' && matrix[2, 1] == 'X') ||
                    (matrix[0, 2] == 'X' && matrix[1, 2] == 'X' && matrix[2, 2] == 'X')
                    ? true : false
                );

            bool oWin =
                (
                    (matrix[0, 0] == 'O' && matrix[1, 1] == 'O' && matrix[2, 2] == 'O') ||
                    (matrix[0, 2] == 'O' && matrix[1, 1] == 'O' && matrix[2, 0] == 'O') ||
                    (matrix[0, 0] == 'O' && matrix[0, 1] == 'O' && matrix[0, 2] == 'O') ||
                    (matrix[1, 0] == 'O' && matrix[1, 1] == 'O' && matrix[1, 2] == 'O') ||
                    (matrix[2, 0] == 'O' && matrix[2, 1] == 'O' && matrix[2, 2] == 'O') ||
                    (matrix[0, 0] == 'O' && matrix[1, 0] == 'O' && matrix[2, 0] == 'O') ||
                    (matrix[0, 1] == 'O' && matrix[1, 1] == 'O' && matrix[2, 1] == 'O') ||
                    (matrix[0, 2] == 'O' && matrix[1, 2] == 'O' && matrix[2, 2] == 'O')
                    ? true : false
                );

            if (xWin) Console.WriteLine("The winner is: X");
            else if (oWin) Console.WriteLine("The winner is: O");
            else Console.WriteLine("There is no winner");

        }
    }
}
