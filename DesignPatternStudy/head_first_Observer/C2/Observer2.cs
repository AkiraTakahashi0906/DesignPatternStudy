using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class Observer2 : IObserver<float>
    {
        private string m_name;
        public Observer2(string name)
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

        public void OnNext(float value)
        {
            Console.WriteLine($"{value}を受け取りました");
        }
    }
}
