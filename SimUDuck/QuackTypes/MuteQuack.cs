using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.QuackTypes
{
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
