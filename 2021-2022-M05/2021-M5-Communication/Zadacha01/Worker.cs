using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Worker
    {
        public delegate void WorkPerfHandler(WorkerPerformedEventArgs e);

        public event WorkPerfHandler WorkPerformed;

        public virtual void DoWork(WorkerPerformedEventArgs e)
        {
            Console.WriteLine($"Start {e.Name} ...");
            var time = e.Hours * 1000;
            Thread.Sleep(time);

            WorkPerformed?.Invoke(e);
        }
        public void workPerformed(WorkerPerformedEventArgs e)
        {
            Console.WriteLine($"Finished after {e.Hours} hours");
        }
    }
}
