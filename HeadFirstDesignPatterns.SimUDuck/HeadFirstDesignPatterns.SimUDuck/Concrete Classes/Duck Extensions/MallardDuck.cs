using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.FlyBehavior_Implementations;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.QuackBehavior_Implementations;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.Duck_Extensions {
    class MallardDuck : Duck {
        public MallardDuck() {
            QuackBehav = new Quack();
            FlyBehav = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
