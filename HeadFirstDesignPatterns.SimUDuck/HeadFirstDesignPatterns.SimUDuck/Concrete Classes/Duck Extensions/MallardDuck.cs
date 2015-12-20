using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;

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
