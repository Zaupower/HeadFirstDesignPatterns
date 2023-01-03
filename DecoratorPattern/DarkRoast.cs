using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "DarkRoast";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
