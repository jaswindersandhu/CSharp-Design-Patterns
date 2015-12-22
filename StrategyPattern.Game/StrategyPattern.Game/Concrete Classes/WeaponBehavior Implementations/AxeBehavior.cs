using System;
using StrategyPattern.Game.Interfaces;

namespace StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations {
    class AxeBehavior : WeaponBehavior {
        public void UseWeapon() {
            Console.WriteLine("<< Chop >>");
        }
    }
}
