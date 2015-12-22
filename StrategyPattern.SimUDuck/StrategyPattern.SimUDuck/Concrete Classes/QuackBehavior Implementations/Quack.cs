using System;
using StrategyPattern.SimUDuck.Interfaces;

namespace StrategyPattern.SimUDuck.Concrete_Classes.QuackBehavior_Implementations {
    class Quack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("Quack");
        }
    }
}
