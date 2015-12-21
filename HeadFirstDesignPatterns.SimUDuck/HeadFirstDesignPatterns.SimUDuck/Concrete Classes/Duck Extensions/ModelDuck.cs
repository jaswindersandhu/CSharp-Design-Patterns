using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.FlyBehavior_Implementations;
using HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.QuackBehavior_Implementations;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.Duck_Extensions {
    class ModelDuck : Duck {
        public ModelDuck() {
            DuckQuackBehavior = new Quack();
            DuckFlyBehavior = new FlyNoWay();
        }

        public override void Display() {
            Console.WriteLine("I'm a model duck");
        }
    }
}
