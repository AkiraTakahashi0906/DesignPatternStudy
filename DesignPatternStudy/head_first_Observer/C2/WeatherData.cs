using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class WeatherData
    {
        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
        public float Temperature { get; }
        public float Humidity { get; }
        public float Pressure { get; }
    }
}
