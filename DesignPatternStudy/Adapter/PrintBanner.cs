using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Adapter
{
    public class PrintBanner : Banner,IPrint
    {
        public PrintBanner(string keyWord):base(keyWord)
        {
        }
        public void PrintStrong()
        {
            ShowWithParen();
        }

        public void PrintWeak()
        {
            ShowWithAster();
        }
    }
}
