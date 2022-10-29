using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 99; int n;
            do
            {
                n = int.Parse(Console.ReadLine());

            } while (n < 1 || n > max);
            int[] a = new int[n + 2];
            for (int i = 1; i <= n; i++)

                a[i] = i;
            a[0] = a[n + 1] = 0;
            do Print(a, n); while (Perm(a, n));
            Console.ReadKey(true);

        }

        public static void Print(int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool Perm(int[] a, int n)
        {
            int j, pom, i = n;
            while (a[i] < a[i - 1]) i--;
            j = i; i--;
            if (i == 0) return false;
            while (a[j] > a[i]) j++;
            pom = a[i]; a[i] = a[j - 1]; a[j - 1] = pom;
            for (j = i + 1; j <= (i + 1 + n) / 2; j++)
            {
                pom = a[j];
                a[j] = a[i + 1 + n - j];
                a[i + 1 + n - j] = pom;
            }
            return true;

        }

    }
}
