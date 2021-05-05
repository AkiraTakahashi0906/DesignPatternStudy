using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class WeatherData2: IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> m_observers = new List<IObserver<WeatherData>>();
        private WeatherData weatherData;
        public void MeasurementsChanged()
        {
            foreach (var observer in m_observers)
            {
                observer.OnNext(weatherData);
            }
        }

        public void SetMeasurementes(float temperature, float humidity, float pressure)
        {
            weatherData = new WeatherData(temperature, humidity, pressure);
            MeasurementsChanged();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!m_observers.Contains(observer))
                m_observers.Add(observer);

            //購読解除用のクラスをIDisposableとして返す
            return new Unsubscriber(m_observers, observer);
        }

        class Unsubscriber : IDisposable
        {
            //発行先リスト
            private List<IObserver<WeatherData>> m_observers;
            //DisposeされたときにRemoveするIObserver<int>
            private IObserver<WeatherData> m_observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                m_observers = observers;
                m_observer = observer;
            }

            public void Dispose()
            {
                //Disposeされたら発行先リストから対象の発行先を削除する
                m_observers.Remove(m_observer);
            }
        }
    }
}
