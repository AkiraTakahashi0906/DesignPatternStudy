using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string _st;
        private int _width;
        public StringDisplay(string st)
        {
            _st = st;
            _width = _st.Length;
        }
        public override void close()
        {
            printLine();
        }
        public override void open()
        {
            printLine();
        }
        public override void print()
        {
            Console.WriteLine("|" + _st + "|");
        }
        private void printLine()
        {
            Console.Write("+");
            for (int i = 0;i< _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
