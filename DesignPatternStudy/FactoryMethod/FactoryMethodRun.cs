using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryMethod
{
    public static class FactoryMethodRun
    {
        public static void Run()
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.create("akira");
            Product card2 = factory.create("takahashi");
            Product card3 = factory.create("s2000");

            card1.use();
            card2.use();
            card3.use();

            Console.ReadKey();
        }
    }
}
