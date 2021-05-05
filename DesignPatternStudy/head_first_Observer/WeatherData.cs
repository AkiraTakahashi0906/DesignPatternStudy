using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer
{
    public class WeatherData : Subject
    {
        private List<Observer> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<Observer>();
        }

        public void NotifyObservers()
        {
            foreach( var observer in _observers){
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurementes(float temperature, float humidity,float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
