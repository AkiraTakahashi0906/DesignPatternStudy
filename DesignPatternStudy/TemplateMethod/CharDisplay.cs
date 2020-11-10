using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private char _ch;
        public CharDisplay(char ch)
        {
            _ch = ch;
        }
        public override void close()
        {
            Console.WriteLine(">>");
        }

        public override void open()
        {
            Console.Write("<<");
        }

        public override void print()
        {
            Console.Write(_ch);
        }
    }
}
