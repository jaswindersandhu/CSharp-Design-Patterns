using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.QuackBehavior_Implementations {
    class Quack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("Quack");
        }
    }
}
