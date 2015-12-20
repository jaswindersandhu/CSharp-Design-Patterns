using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes {
    class Squeak : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("Squeak");
        }
    }
}
