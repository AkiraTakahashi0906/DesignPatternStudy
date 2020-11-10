using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Adapter
{
    public static class AdapterStudy
    {
        public static void Start()
        {
            IPrint p = new PrintBanner("hello");
            p.PrintWeak();
            p.PrintStrong();
            Console.ReadKey();

            IPrint p2 = new PrintBannerDelegate("helloDelegate");
            p2.PrintWeak();
            p2.PrintStrong();
            Console.ReadKey();
        }
    }
}
