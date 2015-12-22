using System;
using StrategyPattern.Game.Interfaces;

namespace StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations {
    class BowAndArrowBehavior : WeaponBehavior {
        public void UseWeapon() {
            Console.WriteLine("<< Volley >>");
        }
    }
}
