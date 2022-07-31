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
            //var phonebook = new Dictionary<string, string>();
            //phonebook["John Smith"] = "+1-555-8976";
            //phonebook["Lisa Smith"] = "+1-555-1234";
            //phonebook["Sam Doe"] = "+1-555-5030";
            //phonebook["Ivan"] = "+359-899-555-592";
            //phonebook["Ivan"] = "+359-2-981-9819"; // Заменяне
            //phonebook.Remove("John Smith");
            //foreach (var pair in phonebook)
            //    Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);

            var events = new SortedDictionary<DateTime, string>();
            events[new DateTime(1998, 9, 4)] = "Google's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni's birth date";
            events[new DateTime(1975, 4, 4)] = "Microsoft's birth date";
            events[new DateTime(2004, 2, 4)] = "Facebook's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni was founded";
            foreach (var entry in events)
            {
                Console.WriteLine("{0:dd-MMM-yyyy}: {1}",
                   entry.Key, entry.Value);
            }


        }
    }
}
