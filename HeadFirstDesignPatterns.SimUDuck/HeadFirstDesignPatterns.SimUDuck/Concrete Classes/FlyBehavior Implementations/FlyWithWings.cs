using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes {
    class FlyWithWings : FlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying!!");
        }
    }
}
