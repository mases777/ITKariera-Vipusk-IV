using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Това е много хубава програма, която написахме в Кърджали.";

            var fileStream = new FileStream("../../log.txt", FileMode.Create);

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
