using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerPerformedEventArgs game = new WorkerPerformedEventArgs("Gaming", 6);
            WorkerPerformedEventArgs develop = new WorkerPerformedEventArgs("Developing", 3);

            Worker worker = new Worker();
            worker.WorkPerformed += worker.workPerformed;

            worker.DoWork(game);
            worker.DoWork(develop);
        }
    }
}
