using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.TemplateMethod
{
    public static class TemplateMethodRun
    {
        public static void Start()
        {
            AbstractDisplay d1 = new CharDisplay('H');
            d1.display();
            Console.ReadKey();

            AbstractDisplay d2 = new StringDisplay("AKIRA");
            d2.display();
            Console.ReadKey();

            //AbstractDisplay d3 = new AbstractDisplay("TEST"); 抽象クラスはインスタンスを生成出来ない。
        }
    }
}
