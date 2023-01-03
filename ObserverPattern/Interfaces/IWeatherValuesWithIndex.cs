﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IWeatherValuesWithIndex
    {
        public float GetHeatIndex();
        public void SetHeatIndex();
    }
}