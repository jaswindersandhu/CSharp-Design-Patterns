using System;
using StrategyPattern.SimUDuck.Abstract_Classes;
using StrategyPattern.SimUDuck.Concrete_Classes.Duck_Extensions;
using StrategyPattern.SimUDuck.Concrete_Classes.FlyBehavior_Implementations;

namespace StrategyPattern.SimUDuck.Driver_Classes {
    class MiniDuckSimulator {
        static void Main(string[] args) {
            Duck duck = new MallardDuck();
            duck.PerformQuack();
            duck.PerformFly();

            duck = new ModelDuck();
            duck.PerformFly();
            duck.DuckFlyBehavior = new FlyRocketPowered();
            duck.PerformFly();

            Console.ReadLine(); // So the console window doesn't close immediately
        }
    }
}
