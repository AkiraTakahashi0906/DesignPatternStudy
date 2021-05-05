using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class WeatherStation2
    {
        public WeatherStation2()
        {
            var weatherData2 = new WeatherData2();
            var A_CurrentConditionsDisplay2 = new CurrentConditionsDisplay2("A_CurrentConditionsDisplay2");
            var B_CurrentConditionsDisplay2 = new CurrentConditionsDisplay2("B_CurrentConditionsDisplay2");
            var C_CurrentConditionsDisplay2 = new CurrentConditionsDisplay2("C_CurrentConditionsDisplay2");
            IDisposable disposableA = weatherData2.Subscribe(A_CurrentConditionsDisplay2);
            IDisposable disposableB = weatherData2.Subscribe(B_CurrentConditionsDisplay2);
            IDisposable disposableC = weatherData2.Subscribe(C_CurrentConditionsDisplay2);
            weatherData2.SetMeasurementes(1f, 2f, 3f);
            disposableA.Dispose();
            weatherData2.SetMeasurementes(4f, 5f, 6f);
        }
    }
}
