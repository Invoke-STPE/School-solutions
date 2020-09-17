using System;

namespace RolePlayV12
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _hitPoints;
        private Sword _sword;
        private Sword _optSword;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints, Sword sword, Sword optSword = null)
        {
            _name = name;
            _hitPoints = hitPoints;
            _sword = sword;
            if (optSword != null) { // If input is given for an optional sword, then use it.
                _optSword = optSword;
            }

        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
        }

        public int DealDamage()
        {
            int swordDMG;
            if (_optSword != null) {
                swordDMG = _sword.DealDamage() + _optSword.DealDamage();
            } else { swordDMG = _sword.DealDamage(); }
            return swordDMG; 
        }

        public string GetInfo()
        {
            return $"{Name} has {HitPoints} hit points ({(Dead ? "dead" : "alive")})";
        }

        // Make it possible to change swords, give them default values!
        public void ChangeSword(Sword sword, Sword optSword = null) {
            
        }
        #endregion
    }
}