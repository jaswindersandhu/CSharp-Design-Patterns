using System;
using HeadFirstDesignPatterns.Game.Interfaces;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations {
    class KnifeBehavior : WeaponBehavior {
        public void UseWeapon() {
            Console.WriteLine("Cut!");
        }
    }
}
