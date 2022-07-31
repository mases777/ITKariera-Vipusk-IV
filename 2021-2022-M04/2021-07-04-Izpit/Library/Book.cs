using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string bookId;
        private Book next;        
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public Book Next
        {
            get { return next; }
            set { next = value; }
        }
        public Book(string bookId)
        {
            this.BookId = bookId;
            this.Next = null;
        }        
        public override string ToString()
        {
            return $"Book: {this.BookId}";
        }

    }
}
