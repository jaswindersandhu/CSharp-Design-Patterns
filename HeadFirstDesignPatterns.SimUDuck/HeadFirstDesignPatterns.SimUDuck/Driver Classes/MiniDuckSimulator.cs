using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.Duck_Extensions;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.FlyBehavior_Implementations;

namespace HeadFirstDesignPatterns.SimUDuck.Driver_Classes {
    class MiniDuckSimulator {
        static void Main(string[] args) {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.DuckFlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.ReadLine(); // So the console window doesn't close immediately
        }
    }
}
