using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var read = new FileStream("../../file.png",FileMode.Open))
            {
                using (var write = new FileStream("../../newfile.png", FileMode.Create))
                {
                    byte[] bytes = new byte[4096];
                    while (true)
                    {
                        int data = read.Read(bytes, 0, bytes.Length);
                        if (data == 0)
                        {
                            break;
                        }
                        write.Write(bytes, 0, bytes.Count());
                    }
                }
            }
        }
    }
}
