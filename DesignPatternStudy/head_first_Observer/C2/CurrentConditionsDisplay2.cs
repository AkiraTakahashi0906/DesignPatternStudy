using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class CurrentConditionsDisplay2 : IObserver<WeatherData>
    {
        private string m_name;
        public CurrentConditionsDisplay2(string name)
        {
            m_name = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine($"通知の受け取りが完了しました");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"次のエラーを受信しました:{error.Message}");
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"{m_name}が");
            Console.WriteLine($"{value}を受け取りました");
        }
    }
}
