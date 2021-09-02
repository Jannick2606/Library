using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public Book(string title, int bookNumber, bool available, string author)
        {
            this.title = title;
            this.bookNumber = bookNumber;
            this.available = available;
            this.author = author;
        }

        private string title;
        private int bookNumber;
        private bool available;
        private string author;

        #region getAndSet
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public int BookNumber
        {
            get
            {
                return bookNumber;
            }
            set
            {
                bookNumber = value;
            }
        }
        public bool Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        #endregion
    }
}
