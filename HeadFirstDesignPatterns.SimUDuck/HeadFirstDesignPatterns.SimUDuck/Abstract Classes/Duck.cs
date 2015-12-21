using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Abstract_Classes {
    abstract class Duck {
        public FlyBehavior DuckFlyBehavior {
            get;
            set;
        }
        public QuackBehavior DuckQuackBehavior {
            get;
            set;
        }

        public Duck() {}

        public abstract void Display();

        public void PerformFly() {
            DuckFlyBehavior.Fly();
        }

        public void PerformQuack() {
            DuckQuackBehavior.DoQuack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
