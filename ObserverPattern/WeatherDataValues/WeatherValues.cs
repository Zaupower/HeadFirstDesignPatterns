using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Helper;
using ObserverPattern.Interfaces;

namespace ObserverPattern.WeatherDataValues
{
    public class WeatherValues : IWeatherValues
    {
        private float _temperature;

        private float _humidity;

        private float _pressure;

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public void SetHumidity(float humidity)
        {
            _humidity = humidity;
        }

        public void SetPressure(float pressure)
        {
            _pressure = pressure;
        }

        public void SetTemperature(float temp)
        {
            _temperature = temp;
        }

        public override string ToString()
        {
            return "Humidity: "+GetHumidity()+"\n" +"Pressure: "+ GetPressure()+"\n"+ "Temperature: "+ GetTemperature()+"\n";
        }
    }
}
