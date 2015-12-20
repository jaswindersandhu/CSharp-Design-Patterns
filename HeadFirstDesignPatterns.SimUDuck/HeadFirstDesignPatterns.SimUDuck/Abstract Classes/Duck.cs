using System;
using HeadFirstDesignPatterns.SimUDuck.Interfaces;

namespace HeadFirstDesignPatterns.SimUDuck.Abstract_Classes {
    abstract class Duck {
        private FlyBehavior flyBehavior;
        private QuackBehavior quackBehavior;

        public Duck() {}

        public abstract void Display();

        public void PerformFly() {
            flyBehavior.Fly();
        }

        public void PerformQuack() {
            quackBehavior.DoQuack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public FlyBehavior FlyBehav {
            get { return flyBehavior; }
            set { flyBehavior = value; }
        }

        public QuackBehavior QuackBehav {
            get { return quackBehavior; }
            set { quackBehavior = value; }
        }
    }
}
