using DesignPatternStudy.Adapter;
using DesignPatternStudy.FactoryMethod;
using DesignPatternStudy.head_first_Observer;
using DesignPatternStudy.head_first_Observer.C2;
using DesignPatternStudy.Iterator;
using DesignPatternStudy.Singleton;
using DesignPatternStudy.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //IteratorStudyRun.Start();
            //AdapterStudy.Start();
            //TemplateMethodRun.Start();
            //FactoryMethodRun.Run();
            //SingletonStudyRun.Run();

            var weatherStation2 = new WeatherStation2();
            Console.ReadKey();
        }
    }
}
