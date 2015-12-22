using System;
using StrategyPattern.Game.Abstract_Classes;
using StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace StrategyPattern.Game.Concrete_Classes.Character_Extensions {
    class Troll : Character {
        public Troll() {
            Weapon = new KnifeBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Hand it over!");
        }
    }
}
