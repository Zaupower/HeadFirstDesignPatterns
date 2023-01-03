﻿using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    public class ForecastDisplay<T> : IObserver<T>, IDisplayElement
    {
        private IDisposable _cancellation;

        public virtual void Subscribe(WeatherData<T> provider)
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

        public void OnNext(T value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
