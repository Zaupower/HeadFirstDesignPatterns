using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver<IWeatherValues>, IDisplayElement
    {
        private IDisposable _cancellation;

        public virtual void Subscribe(WeatherData provider)
        {
            _cancellation = provider.Subscribe(this);
        }
        public void Display()
        {
            throw new NotImplementedException();
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(IWeatherValues value)
        {
            Console.WriteLine("Forecast New Weather Info received");
            Console.WriteLine("Pressure: "+value.GetPressure());
            Console.WriteLine("Humidity: " + value.GetHumidity());
            Console.WriteLine("Temperature: " + value.GetTemperature());
            Console.WriteLine(" ");
        }
    }
}
