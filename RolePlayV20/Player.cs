using System;

namespace RolePlayV20
{
    class Player {
        #region Instance fields
        private NumberGenerator _generator;
        private BattleLog _log;
        #endregion
        #region Property
        private string Type {get;}
        private int MinDMG {get; set;}
        private int MaxDMG {get; set;}
        private int HitPoints {get; set;}

        public bool Dead {
            get { return HitPoints <= 0; }
        }
        #endregion

        #region Construct
        public Player(NumberGenerator generator, BattleLog log, string type, int minDMG = 10, int maxDMG = 30, int hitPoints = 100) 
        {
            _generator = generator;
            _log = log;
            _log = log;
            Type = type;
            MinDMG = minDMG;
            MaxDMG = maxDMG;
            HitPoints = hitPoints;
        }
        #endregion

        #region Methods
        public int DealDamage()
        {
            int damage = _generator.Next(MinDMG, MaxDMG);
            string message = $"{Type} dealt {damage} damage!";
            _log.Save(message);
            return damage;
        }
        public void ReceiveDamage(int points)
        {
            HitPoints = HitPoints - points;
            string message = $"{Type} receives {points} damage, and is down to {HitPoints} hit points";
            _log.Save(message);
            if (Dead)
            {
                _log.Save("Beast died!");
            }
        }
        #endregion
    }
}