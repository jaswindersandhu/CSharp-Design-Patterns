using System;
using HeadFirstDesignPatterns.Game.Abstract_Classes;
using HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.Character_Extensions {
    class King : Character {
        public King() {
            Weapon = new SwordBehavior();
        }

        public override void Fight() {
            Console.WriteLine("To arms!");
        }
    }
}
