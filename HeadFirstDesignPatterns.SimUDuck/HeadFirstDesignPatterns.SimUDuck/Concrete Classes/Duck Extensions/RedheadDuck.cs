using System;
using HeadFirstDesignPatterns.SimUDuck.Abstract_Classes;

namespace HeadFirstDesignPatterns.SimUDuck.Concrete_Classes.Duck_Extensions {
    class RedheadDuck : Duck {
        public override void Display() {
            Console.WriteLine("I'm a Redhead duck");
        }
    }
}
