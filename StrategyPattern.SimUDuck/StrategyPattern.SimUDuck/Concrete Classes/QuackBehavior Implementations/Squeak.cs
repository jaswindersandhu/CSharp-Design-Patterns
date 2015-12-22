using System;
using StrategyPattern.SimUDuck.Interfaces;

namespace StrategyPattern.SimUDuck.Concrete_Classes.QuackBehavior_Implementations {
    class Squeak : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("Squeak");
        }
    }
}
