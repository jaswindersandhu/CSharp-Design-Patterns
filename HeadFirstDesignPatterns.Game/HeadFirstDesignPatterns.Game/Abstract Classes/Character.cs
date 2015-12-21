using System;
using HeadFirstDesignPatterns.Game.Interfaces;

namespace HeadFirstDesignPatterns.Game.Abstract_Classes {
    abstract class Character {
        WeaponBehavior weapon;

        public Character() {}

        public abstract void Fight();

        public void PerformUseWeapon() {
            weapon.UseWeapon();
        }

        public WeaponBehavior Weapon {
            get { return weapon; }
            set { weapon = value; }
        }
    }
}
