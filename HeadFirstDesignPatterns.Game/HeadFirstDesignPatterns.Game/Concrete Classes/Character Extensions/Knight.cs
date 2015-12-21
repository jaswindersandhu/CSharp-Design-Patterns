using System;
using HeadFirstDesignPatterns.Game.Abstract_Classes;
using HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.Character_Extensions {
    class Knight : Character {
        public Knight() {
            Weapon = new AxeBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Come get some!");
        }
    }
}
