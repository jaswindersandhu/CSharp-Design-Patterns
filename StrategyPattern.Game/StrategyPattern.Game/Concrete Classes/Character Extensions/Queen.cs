using System;
using StrategyPattern.Game.Abstract_Classes;
using StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace StrategyPattern.Game.Concrete_Classes.Character_Extensions {
    class Queen : Character {
        public Queen() {
            Weapon = new BowAndArrowBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Oh dear!");
        }
    }
}
