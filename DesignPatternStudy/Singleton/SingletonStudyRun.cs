using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Singleton
{
    public static class SingletonStudyRun
    {
        public static void Run()
        {
            Console.WriteLine("START");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("同一インスタンス");
            }
            else
            {
                Console.WriteLine("同一インスタンスではない");
            }
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
