using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Book
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"{this.Title}. {this.Year}. {string.Join(", ", this.Authors)}";
        }
    }
}
