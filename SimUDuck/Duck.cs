using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class Duck
    {
        private FlyBehavior _flyBehavior;
        private QuackBehavior _quackBehavior;


        public Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void performQuack()
        {
            _quackBehavior.Quack();
        }

        public void swim()
        {
            Console.WriteLine("swim");
        }

        public void display()
        {
            Console.WriteLine("display");
        }

        public void performFly()
        {
            _flyBehavior.Fly();
        }

    }
}
