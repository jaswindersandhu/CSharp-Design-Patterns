using System;
using StrategyPattern.SimUDuck.Abstract_Classes;
using StrategyPattern.SimUDuck.Concrete_Classes.FlyBehavior_Implementations;
using StrategyPattern.SimUDuck.Concrete_Classes.QuackBehavior_Implementations;

namespace StrategyPattern.SimUDuck.Concrete_Classes.Duck_Extensions {
    class MallardDuck : Duck {
        public MallardDuck() {
            DuckQuackBehavior = new Quack();
            DuckFlyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
