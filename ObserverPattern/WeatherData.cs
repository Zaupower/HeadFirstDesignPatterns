using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData<T> : IObservable<T>
    {
        private static Lazy<WeatherData<T>> _instance = new Lazy<WeatherData<T>>(() => new WeatherData<T>());
        
        public static WeatherData<T> Instance => _instance.Value;

        private List<IObserver<T>> _observers;
        private T _weatherValues;

        public WeatherData()
        {
            _observers = new List<IObserver<T>>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                //Update observer added 
                //foreach(var item in )
            }
            return new Unsubscriber<T>(_observers, observer);
        }

        public T Get_weatherValues()
        {
            return _weatherValues;
        }

        public void measurementsChanged(T values)
        {
            _weatherValues = values;

            NotifyAllObserversAboutNewWeatherData();
        }
        //Notify All Observers about new transaction
        private void NotifyAllObserversAboutNewWeatherData()
        {
            foreach (IObserver<T> observer in _observers)
            {
                observer.OnNext(_weatherValues);
            }
        }


    }
}
