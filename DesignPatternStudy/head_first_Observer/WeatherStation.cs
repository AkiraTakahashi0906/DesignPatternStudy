using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer
{
    public class WeatherStation
    {
        public WeatherStation()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var currentConditionsDisplay2 = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurementes(2.7f, 65f, 30.4f);
            weatherData.SetMeasurementes(2.8f, 64f, 31.4f);
            weatherData.SetMeasurementes(2.9f, 65f, 32.4f);
        }
    }
}
