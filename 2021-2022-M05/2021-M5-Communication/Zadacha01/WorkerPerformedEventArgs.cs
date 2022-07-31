using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class WorkerPerformedEventArgs : EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int hours;
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public WorkerPerformedEventArgs(string name, int hours)
        {
            this.Name = name;
            this.Hours = hours;
        }
    }
}
