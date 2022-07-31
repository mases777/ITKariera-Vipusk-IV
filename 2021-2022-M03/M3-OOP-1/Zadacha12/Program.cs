using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BigTruck = 22; Truck = 15; LitlleTruck = 7;
            Rock = 18; Silk = 12; Water = 3
            BigTruck Rock
            Truck Water
            Truck Water
            Truck Rock
            LittleTruck Water
            LittleTruck Water
            END*/
            var trucks = new List<Truck>();
            var cmd = Console.ReadLine().Split(';').ToArray();
            foreach (var item in cmd)
            {
                var next = item.Split('=').ToArray();
                try
                {
                    trucks.Add
                        (
                        new Truck(next[0], int.Parse(next[1]))
                        );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var freights = new List<Freight>();
            cmd = Console.ReadLine().Split(';').ToArray();
            foreach (var item in cmd)
            {
                var next = item.Split('=').ToArray();
                try
                {
                    freights.Add
                        (
                        new Freight(next[0], double.Parse(next[1]))
                        );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                try
                {
                    trucks.FirstOrDefault(x => x.Name == cmd[0]).Add
                        (
                        freights.FirstOrDefault(x => x.Name == cmd[1])
                        );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                cmd = Console.ReadLine().Split().ToArray();
            }

            trucks.ForEach(x => Console.WriteLine(x));
        }
    }
}
