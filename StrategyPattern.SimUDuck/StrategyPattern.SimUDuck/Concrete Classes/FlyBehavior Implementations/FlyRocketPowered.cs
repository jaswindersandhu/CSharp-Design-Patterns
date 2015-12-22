using System;
using StrategyPattern.SimUDuck.Interfaces;
namespace StrategyPattern.SimUDuck.Concrete_Classes.FlyBehavior_Implementations {
    class FlyRocketPowered : FlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
