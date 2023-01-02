﻿using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver<IWeatherValues>, IDisplayElement
    {
        private IDisposable cancellation;

        public virtual void Subscribe(WeatherData provider)
        {
            cancellation = provider.Subscribe(this);
        }
        public void Display()
        {
            throw new NotImplementedException();
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
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
            Console.WriteLine("CurrentConditionsDisplay New Weather Info received");
            Console.WriteLine("Pressure: "+value.GetPressure());
            Console.WriteLine("Humidity: " + value.GetHumidity());
            Console.WriteLine("Temperature: " + value.GetTemperature());
            Console.WriteLine(" ");
        }
    }
}
