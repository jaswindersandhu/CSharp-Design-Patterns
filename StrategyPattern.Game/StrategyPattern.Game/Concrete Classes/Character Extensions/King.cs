using System;
using StrategyPattern.Game.Abstract_Classes;
using StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace StrategyPattern.Game.Concrete_Classes.Character_Extensions {
    class King : Character {
        public King() {
            Weapon = new SwordBehavior();
        }

        public override void Fight() {
            Console.WriteLine("To arms!");
        }
    }
}
