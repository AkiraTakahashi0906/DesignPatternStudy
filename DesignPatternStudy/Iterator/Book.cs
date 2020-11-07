using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Iterator
{
    public class Book
    {
        private string _name;
        public Book(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
    }
}
