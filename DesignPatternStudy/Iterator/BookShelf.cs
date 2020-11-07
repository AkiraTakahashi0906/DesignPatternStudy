using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Iterator
{
    public class BookShelf : IAggregate
    {
        private Book[] _books;
        private int last = 0;

        public BookShelf(int maxsize)
        {
            _books = new Book[maxsize];
        }

        public Book getBookAt(int index)
        {
            return _books[index];
        }

        public void appendBook(Book book)
        {
            _books[last] = book;
            last++;
        }

        public int getLength()
        {
            return last;
        }

        public IIterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
