using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string _description = "Unknown Beverage";

        public string GetDescription()
        {
            return _description;
        }

        public abstract double cost();
    }
}
