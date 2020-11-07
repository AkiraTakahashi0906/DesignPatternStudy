using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Iterator
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }
        public bool hasNext()
        {
            if (_index < _bookShelf.getLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object next()
        {
            Book book = _bookShelf.getBookAt(_index);
            _index++;
            return book;
        }
    }
}
