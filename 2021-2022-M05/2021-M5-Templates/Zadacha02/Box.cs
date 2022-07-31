using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            this.data.Add(item);
            this.Count++;
        }

        public T Remove()
        {
            var remove = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            this.Count--;
            return remove;
        }

        public override string ToString()
        {
            string temp = null;
            string type = null;
            foreach (var item in data)
            {
                type = item.GetType().ToString();
                temp += item.ToString();
            };
            return $"{type}: {temp}";
        }
    }
}
