using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private Subject _weatherData;

        public CurrentConditionsDisplay(Subject weaterData)
        {
            _weatherData = weaterData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("現在の気象状況：温度" + _temperature + "度　湿度" + _humidity + "%");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
