using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.CondimentDecorators
{
    public class Milk : CondimentDecorator
    {
        private Beverage Beverage;
        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override double cost()
        {
            return .20 + Beverage.cost();
        }

        public override string getDescription()
        {
            return Beverage.GetDescription();
        }
    }
}
