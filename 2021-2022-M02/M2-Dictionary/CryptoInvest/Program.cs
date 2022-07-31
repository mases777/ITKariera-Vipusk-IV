using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var etheriums = double.Parse(Console.ReadLine());
            var litecoins = double.Parse(Console.ReadLine());
            var transaction = int.Parse(Console.ReadLine());
            var allStocks = 0M;
            for (int i = 0; i < transaction; i++)
            {
                var stock = 0M;
                var sumCommision = 0M;
                var numberOfAssets = int.Parse(Console.ReadLine());
                var currencyName = Console.ReadLine();
                var buySell = Console.ReadLine();
                if (currencyName == "Bitcoin")
                    stock += Convert.ToDecimal(numberOfAssets * bitcoins);
                else if (currencyName == "Ethereum")
                    stock += Convert.ToDecimal(numberOfAssets * etheriums);
                else if (currencyName == "Litecoin")
                    stock += Convert.ToDecimal(numberOfAssets * litecoins);
                sumCommision += stock * 0.073456764216789345M;
                if (buySell == "Buy")
                {
                    allStocks = allStocks + stock - sumCommision;
                }
                else
                {
                    allStocks = allStocks - stock - sumCommision;
                }
            }
            
            Console.WriteLine($"{allStocks:f16}");

        }
    }
}
