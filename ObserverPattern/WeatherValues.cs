using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class WeatherValues : IWeatherValues
    {
        public float temperature { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public void SetHumidity(float humidity)
        {
            this.humidity = humidity;
        }

        public void SetPressure(float pressure)
        {
            this.pressure = pressure;  
        }

        public void SetTemperature(float temp)
        {
            this.temperature = temp;
        }
    }
}
