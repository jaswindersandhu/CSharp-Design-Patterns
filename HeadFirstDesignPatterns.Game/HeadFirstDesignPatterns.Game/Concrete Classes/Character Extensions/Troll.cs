using System;
using HeadFirstDesignPatterns.Game.Abstract_Classes;
using HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.Character_Extensions {
    class Troll : Character {
        public Troll() {
            Weapon = new KnifeBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Hand it over!");
        }
    }
}
