using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Search
    {
        public static int Binary<T>(T[] elements, T key)
            where T : IComparable
        {
            int start = 0;
            int end = elements.Count() - 1;

            while (end >= start)
            {
                int middle = (start + end) / 2;
                if (elements[middle].CompareTo(key) > 0)
                {
                    end = middle - 1;
                }
                else if (elements[middle].CompareTo(key) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}
