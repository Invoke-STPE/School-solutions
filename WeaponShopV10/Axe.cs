﻿namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Axe. An Axe is 
    /// considered to be a weapon.
    /// </summary>
    public class Axe : Weapon
    {
        public const int InitialAxeMinDamage = 20;
        public const int InitialAxeMaxDamage = 50;
        private int MinDmg;
        private int MaxDmg;

        #region Constructor
        public Axe(string description) 
            : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
        {
        }
        #endregion

        public int DamageFromAxe()
        {
            int dmg = base.CalculateDamage();
            base.MinDamage -= 3;
            base.MaxDamage -= 3;
            return dmg;
        }

        public void Sharpen() // THIS FUCKING MAKES IT TICK 3 OFF DMG ALL THE TIME????
        {
            base.MinDamage = (int)InitialAxeMaxDamage;
            base.MaxDamage = (int)InitialAxeMaxDamage;
        }
        public override string ToString()
        {
            return $"Axe min dmg: {base.MinDamage} Wand max dmg: {base.MaxDamage}";
        }
        
    }
}