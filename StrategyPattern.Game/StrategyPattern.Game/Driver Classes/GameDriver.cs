using System;
using StrategyPattern.Game.Concrete_Classes.Character_Extensions;
using StrategyPattern.Game.Concrete_Classes.WeaponBehavior_Implementations;
using StrategyPattern.Game.Abstract_Classes;

namespace StrategyPattern.Game.Driver_Classes {
    class GameDriver {
        static void Main(string[] args) {
            Character james = new King();
            Character mary = new Queen();
            james.Fight();
            james.PerformUseWeapon();
            mary.Fight();
            mary.PerformUseWeapon();
            //mary needs a better weapon
            mary.Weapon = new AxeBehavior();
            mary.PerformUseWeapon();

            Console.ReadLine();
        }
    }
}
