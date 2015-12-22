using System;
using StrategyPattern.SimUDuck.Interfaces;

namespace StrategyPattern.SimUDuck.Concrete_Classes.FlyBehavior_Implementations {
    class FlyWithWings : FlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying!!");
        }
    }
}
