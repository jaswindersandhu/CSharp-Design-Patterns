using System;
using HeadFirstDesignPatterns.Game.Concrete_Classes.Character_Extensions;
using HeadFirstDesignPatterns.Game.Abstract_Classes;

namespace HeadFirstDesignPatterns.Game.Driver_Classes {
    class GameDriver {
        static void Main(string[] args) {
            Character james = new King();
            Character mary = new Queen();
            james.Fight();
            james.PerformUseWeapon();
            mary.Fight();
            mary.PerformUseWeapon();

            Console.ReadLine();
        }
    }
}
