using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : IObservable<IWeatherValues>
    {
        private static Lazy<WeatherData> _instance = new Lazy<WeatherData>(() => new WeatherData());
        public static WeatherData Instance => _instance.Value;

        private List<IObserver<IWeatherValues>> _observers;
        private IWeatherValues _weatherValues;

        public WeatherData()
        {
            _observers = new List<IObserver<IWeatherValues>>();
        }

        public IDisposable Subscribe(IObserver<IWeatherValues> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                //Update observer added 
                //foreach(var item in )
            }
            return new Unsubscriber<IWeatherValues>(_observers, observer);
        }

        public IWeatherValues Get_weatherValues()
        {
            return _weatherValues;
        }

        public void measurementsChanged(WeatherValues values)
        {
            _weatherValues = values;

            NotifyAllObserversAboutNewWeatherData();
        }
        //Notify All Observers about new transaction
        private void NotifyAllObserversAboutNewWeatherData()
        {
            foreach (IObserver<IWeatherValues> observer in _observers)
            {
                observer.OnNext(_weatherValues);
            }
        }


    }
}
