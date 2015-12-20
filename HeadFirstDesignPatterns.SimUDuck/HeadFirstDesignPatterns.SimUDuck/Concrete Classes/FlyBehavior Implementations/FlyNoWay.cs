using HeadFirstDesignPatterns.SimUDuck.Interfaces;
using System;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes {
    class FlyNoWay : FlyBehavior {
        public void Fly() {
            Console.WriteLine("I can't fly");
        }
    }
}
