using System;

namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private double _hp;
        private bool _dead;

        #endregion


        #region Constructor
        public Warrior(string name, double hp)
        {
            _name = name;
            _level = 1;
            _hp = hp;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public double Hp {
            get { return _hp; }
        }

        public bool Dead {
            get {
                if (_hp <= 0) {
                    _dead = true;
                } else {_dead = false;}
                return _dead;
            }
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }

        public void DecreaseHP(int dmg){
            _hp -= dmg;
        }

        public int DealDamage() {
            var rand = new Random();
            return rand.Next(10, 31);
        }
        #endregion
    }
}