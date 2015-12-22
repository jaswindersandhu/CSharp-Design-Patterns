using System;
using StrategyPattern.SimUDuck.Abstract_Classes;

namespace StrategyPattern.SimUDuck.Concrete_Classes.Duck_Extensions {
    class RedheadDuck : Duck {
        public override void Display() {
            Console.WriteLine("I'm a Redhead duck");
        }
    }
}
