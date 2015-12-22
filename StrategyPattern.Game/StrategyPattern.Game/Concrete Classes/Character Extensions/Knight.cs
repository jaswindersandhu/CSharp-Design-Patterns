using System;
using StrategyPattern.Game.Abstract_Classes;
using StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations;

namespace StrategyPattern.Game.Concrete_Classes.Character_Extensions {
    class Knight : Character {
        public Knight() {
            Weapon = new AxeBehavior();
        }

        public override void Fight() {
            Console.WriteLine("Come get some!");
        }
    }
}
