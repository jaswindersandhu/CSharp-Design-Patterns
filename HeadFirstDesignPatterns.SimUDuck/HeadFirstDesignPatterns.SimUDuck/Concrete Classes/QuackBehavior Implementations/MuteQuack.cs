using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.QuackBehavior_Implementations {
    class MuteQuack : QuackBehavior {
        public void DoQuack() {
            Console.WriteLine("<< Silence >>");
        }
    }
}
