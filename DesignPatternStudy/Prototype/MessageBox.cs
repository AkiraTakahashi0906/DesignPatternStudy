using DesignPatternStudy.Prototype.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Prototype
{
    public class MessageBox : Product
    {
        private char _decochar;
        public MessageBox(char decochar)
        {
            _decochar = decochar;
        }

        public void use(string s)
        {
            Encoding sjisEnc = Encoding.GetEncoding("shift_jis");
            int length = sjisEnc.GetByteCount(s);
            for (int i = 0;i <length +4; i++)
            {
                Console.WriteLine(_decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{_decochar}{s}{_decochar}");
            for (int i =0;i<length + 4; i++)
            {
                Console.WriteLine(_decochar);
            }
            Console.WriteLine("123");
            
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Product CreateClone()
        {
            throw new NotImplementedException();
        }

    }
}
