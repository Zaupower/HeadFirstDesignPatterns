using ObserverPattern.Helper;
using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDataValues
{
    public class WeatherValuesWithHeatIndex : WeatherValues, IWeatherValuesWithIndex
    {
        private float _heatIndex;

        public float GetHeatIndex()
        {
            return _heatIndex;
        }

        public void SetHeatIndex()
        {
            _heatIndex = WeatherCalculation.computeHeatIndex(GetTemperature(), GetHumidity());
        }

        public override string ToString()
        {

            return base.ToString()+ "Heat Index: "+ GetHeatIndex()+"\n";
        }

    }
}
