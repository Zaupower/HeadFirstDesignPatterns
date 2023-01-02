using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IWeatherValues
    {
        public float GetTemperature();
        public float GetHumidity();
        public float GetPressure();

        public void SetTemperature(float temp);
        public void SetHumidity(float humidity);
        public void SetPressure(float pressure);
    }
}
