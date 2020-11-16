using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("インスタンスを作成しました");
        }
        public static Singleton getInstance()
        {
            return _singleton;
        }
    }
}
