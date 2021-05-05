using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer.C2
{
    public class Observable2 : IObservable<float>
    {
        private List<IObserver<float>> m_observers = new List<IObserver<float>>();
        public IDisposable Subscribe(IObserver<float> observer)
        {
            if (!m_observers.Contains(observer))
                m_observers.Add(observer);

            //購読解除用のクラスをIDisposableとして返す
            return new Unsubscriber(m_observers, observer);
        }

        class Unsubscriber : IDisposable
        {
            //発行先リスト
            private List<IObserver<float>> m_observers;
            //DisposeされたときにRemoveするIObserver<int>
            private IObserver<float> m_observer;

            public Unsubscriber(List<IObserver<float>> observers, IObserver<float> observer)
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
