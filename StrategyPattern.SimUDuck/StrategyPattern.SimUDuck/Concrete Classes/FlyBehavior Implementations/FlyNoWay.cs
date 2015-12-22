using StrategyPattern.SimUDuck.Interfaces;
using System;

namespace StrategyPattern.SimUDuck.Concrete_Classes.FlyBehavior_Implementations {
    class FlyNoWay : FlyBehavior {
        public void Fly() {
            Console.WriteLine("I can't fly");
        }
    }
}
