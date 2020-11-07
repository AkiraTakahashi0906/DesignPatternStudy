using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Iterator
{
    public class BookShelfEnumerable : IEnumerable<Book>
    {
        public List<Book> Books { get; } = new List<Book>();

        public void Add(Book book)
        {
            this.Books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
                for (int i = 0; i < this.Books.Count; i++)
                {
                    yield return this.Books[i];
                }
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
