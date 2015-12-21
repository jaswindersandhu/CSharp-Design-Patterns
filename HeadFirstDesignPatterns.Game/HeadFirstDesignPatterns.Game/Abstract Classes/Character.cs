using System;
using HeadFirstDesignPatterns.Game.Interfaces;

namespace HeadFirstDesignPatterns.Game.Abstract_Classes {
    abstract class Character {
        public WeaponBehavior Weapon {
            get;
            set;
        }

        public Character() {}

        public abstract void Fight();

        public void PerformUseWeapon() {
            Weapon.UseWeapon();
        }


    }
}
