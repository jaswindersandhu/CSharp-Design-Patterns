using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes {
    class Quack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("Quack");
        }
    }
}
