using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Engine
    {
        private Controller controller;
        public Engine()
        {
            controller = new Controller();
        }
        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                List<string> lineArgs = Console.ReadLine().Split(' ').ToList();
                string command = lineArgs[0];
                lineArgs = lineArgs.Skip(1).ToList();
                try
                {
                    switch (command)
                    {
                        case "Village":
                            Console.WriteLine(controller.ProceseVillageCommand(lineArgs)); break;
                        case "Settle":
                            Console.WriteLine(controller.ProcessSettleCommand(lineArgs)); break;
                        case "Rebel":
                            Console.WriteLine(controller.ProcessRebelCommand(lineArgs)); break;
                        case "Day":
                            Console.WriteLine(controller.ProcessDayCommand(lineArgs)); break;
                        case "Attack":
                            Console.WriteLine(controller.ProcessAttackCommand(lineArgs)); break;
                        case "Info":
                            Console.WriteLine(controller.ProcessInfoCommand(lineArgs)); break;
                        case "End":
                            Console.WriteLine(controller.ProcessEndCommand()); isRunning = false; break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}