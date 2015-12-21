using System;
using HeadFirstDesignPatterns.Game.Abstract_Classes;
using HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.Character_Extensions {
    class Queen : Character {
        public Queen() {
            Weapon = new BowAndArrowBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Oh dear!");
        }
    }
}
