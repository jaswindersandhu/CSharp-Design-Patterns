﻿using System;
using HeadFirstDesignPatterns.Game.Interfaces;

namespace HeadFirstDesignPatterns.Game.Concrete_Classes.WeaponBehavior_Implementations {
    class SwordBehavior : WeaponBehavior {
        public void UseWeapon() {
            Console.WriteLine("<< Swing >>");
        }
    }
}
