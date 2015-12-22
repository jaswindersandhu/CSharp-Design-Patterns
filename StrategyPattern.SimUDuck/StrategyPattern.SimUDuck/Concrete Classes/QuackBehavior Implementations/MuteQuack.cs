using System;
using StrategyPattern.SimUDuck.Interfaces;

namespace StrategyPattern.SimUDuck.Concrete_Classes.QuackBehavior_Implementations {
    class MuteQuack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("<< Silence >>");
        }
    }
}
