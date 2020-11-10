using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Adapter
{
    public class Banner
    {
        private string _keyWord;
        public Banner(string keyWord)
        {
            _keyWord = keyWord;
        }
        public void ShowWithParen()
        {
            Console.WriteLine("(" + _keyWord + ")");
        }
        public void ShowWithAster()
        {
            Console.WriteLine("*" + _keyWord + "*");
        }
    }
}
