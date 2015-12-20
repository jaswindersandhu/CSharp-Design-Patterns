using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes {
    class MuteQuack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("<< Silence >>");
        }
    }
}
