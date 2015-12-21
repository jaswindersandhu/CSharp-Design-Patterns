using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.SimUDuck.Interfaces {
    interface QuackBehavior {
        // Originally "quack()" in the book, but C# conventions dictate using PascalCase for methods.
        // Class Quack is not allowed to have a method called Quack(), as a consequence.
        void DoQuack(); 
    }
}
