using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int redEggsCount = 0, orangeEggsCount = 0, blueEggsCount = 0, greenEggsCount = 0;

            for (int i = 0; i < eggsCount; i++)
            {
                String eggsCollor = Console.ReadLine();

                switch (eggsCollor)
                {
                    case "red":
                        redEggsCount++;
                        break;
                    case "orange":
                        orangeEggsCount++;
                        break;
                    case "blue":
                        blueEggsCount++;
                        break;
                    case "green":
                        greenEggsCount++;
                        break;
                }
            }
            int maxEggsCounts = redEggsCount;
            String maxCollor = "red";


            if (orangeEggsCount > maxEggsCounts)
            {
                maxEggsCounts = orangeEggsCount;
                maxCollor = "orange";
            }
            if (blueEggsCount > maxEggsCounts)
            {
                maxEggsCounts = blueEggsCount;
                maxCollor = "blue";
            }
            if (greenEggsCount > maxEggsCounts)
            {
                maxEggsCounts = greenEggsCount;
                maxCollor = "green";
            }
            Console.WriteLine("Red eggs: " + redEggsCount + "\n"
                + "Orange eggs: " + orangeEggsCount + "\n"
                + "Blue eggs: " + blueEggsCount + "\n"
                + "Green eggs: " + greenEggsCount + "\n"
                + "Max eggs: " + maxEggsCounts + " -> " + maxCollor);



            //int countEgg = int.Parse(Console.ReadLine());

            //var eggs = new Dictionary<string, int>();
            //for (int i = 0; i < countEgg; i++)
            //{
            //    var egg = Console.ReadLine();
            //    if (eggs.ContainsKey(egg)) eggs[egg] += 1;
            //    else eggs.Add(egg, 1);
            //}
            //Console.WriteLine($"Red eggs: {eggs.Where(x => x.Key == "red").Max(x => x.Value)}");
            //Console.WriteLine($"Orange eggs: {eggs.Where(x => x.Key == "orange").Max(x => x.Value)}");
            //Console.WriteLine($"Blue eggs: {eggs.Where(x => x.Key == "blue").Max(x => x.Value)}");
            //Console.WriteLine($"Green eggs: {eggs.Where(x => x.Key == "green").Max(x => x.Value)}");

            //Console.WriteLine($"Max eggs: {eggs.Max(x => x.Value)} -> {eggs.Max(x => x.Key)}");

        }
    }
}
