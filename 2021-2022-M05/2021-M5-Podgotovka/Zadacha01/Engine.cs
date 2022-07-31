using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Engine
    {
        private CompanyController controller;
        public Engine()
        {
            controller = new CompanyController();
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    List<string> line = Console.ReadLine().Split('*').ToList();
                    string cmd = line[0];
                    if (cmd == "Shutdown")
                    {
                        Console.WriteLine(controller.Shutdown());
                        break;
                    }
                    switch (cmd)
                    {
                        case "CreateCompany":
                            Console.WriteLine(controller.CreateCompany(line));
                            break;
                        case "RegisterBuilding":
                            Console.WriteLine(controller.RegisterBuilding(line));
                            break;
                        case "RegisterBroker":
                            Console.WriteLine(controller.RegisterBroker(line)); break;
                        case "RentBulding":
                            Console.WriteLine(controller.RentBuilding(line));break;
                        case "CompanyInfo":
                            Console.WriteLine(controller.CompanyInfo(line)); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
