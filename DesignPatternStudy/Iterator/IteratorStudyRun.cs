using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternStudy.Iterator
{
    public static class IteratorStudyRun
    {
        public static void Start()
        {
            BookShelf bookshelf = new BookShelf(3);
            bookshelf.appendBook(new Book("testA"));
            bookshelf.appendBook(new Book("testB"));
            bookshelf.appendBook(new Book("testC"));
            IIterator it = bookshelf.iterator();
            while (it.hasNext())
            {
                Book book = (Book)it.next();
                Console.WriteLine(book.getName());
            }
            Console.ReadKey();

            BookShelfEnumerable bookShelfEnumerable = new BookShelfEnumerable();
            bookShelfEnumerable.Add(new Book("EnumerabletestA"));
            bookShelfEnumerable.Add(new Book("EnumerabletestB"));
            bookShelfEnumerable.Add(new Book("EnumerabletestC"));

            foreach (var book in bookShelfEnumerable)
            {
                Console.WriteLine(book.getName());
            }
            Console.ReadKey();
        }
    }
}
