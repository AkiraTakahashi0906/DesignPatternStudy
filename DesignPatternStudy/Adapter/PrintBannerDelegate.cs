using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Adapter
{
    public class PrintBannerDelegate : IPrint
    {
        private Banner _banner;
        public PrintBannerDelegate(string keyWord)
        {
            _banner = new Banner(keyWord);
        }
        public void PrintStrong()
        {
            _banner.ShowWithParen();
        }
        public void PrintWeak()
        {
            _banner.ShowWithAster();
        }
    }
}
