using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver<IWeatherValues>, IDisplayElement
    {
        public void Display()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("New Weather Info received");
            Console.WriteLine("Pressure: "+value.GetPressure());
            Console.WriteLine("Humidity: " + value.GetHumidity());
            Console.WriteLine("Temperature: " + value.GetTemperature());
        }
    }
}
