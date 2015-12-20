using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck.Interfaces {
    interface QuackBehavior {
        // Originally "quack()" in the book, but C# conventions dictate using camel-case
        // with the first letter upper-case for methods. This won't work with class Quack
        // having a method called Quack()
        void DoQuack(); 
    }
}
