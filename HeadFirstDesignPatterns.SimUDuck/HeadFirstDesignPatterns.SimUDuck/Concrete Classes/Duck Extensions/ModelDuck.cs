using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.Duck_Extensions {
    class ModelDuck : Duck {
        public ModelDuck() {
            QuackBehav = new Quack();
            FlyBehav = new FlyNoWay();
        }

        public override void Display() {
            Console.WriteLine("I'm a model duck");
        }
    }
}
