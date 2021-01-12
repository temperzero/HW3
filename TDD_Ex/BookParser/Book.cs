using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParser
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;

        public Book(string title, string author, string isbn)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
        }

        public string Title { get { return _title; } }
        public string Author { get { return _author; } }
        public string ISBN { get { return _isbn; } }
    }
}
