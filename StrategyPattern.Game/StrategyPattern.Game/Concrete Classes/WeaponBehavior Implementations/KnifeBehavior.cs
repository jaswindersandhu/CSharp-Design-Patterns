using System;
using StrategyPattern.Game.Interfaces;

namespace StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations {
    class KnifeBehavior : WeaponBehavior {
        public void UseWeapon() {
            Console.WriteLine("Cut!");
        }
    }
}
