using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha09
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double limit = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double priceDiff = CalculatePriceDifference(lastPrice, currentPrice);
                bool isSignificantDifference = imaliDif(priceDiff, limit);
                string message = GetMessage(currentPrice, lastPrice, priceDiff, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetMessage(double c, double last, double razlika, bool etherTrueOrFalse)
        {
            string to = "";
            if (razlika == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
            }
            else if (etherTrueOrFalse && (razlika > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
            }
            else if (etherTrueOrFalse && (razlika < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
            return to;
        }
        private static bool imaliDif(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double CalculatePriceDifference(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}
