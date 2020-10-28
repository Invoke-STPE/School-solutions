using System;

namespace RolePlayV23
{
    class Fighter : Character
    {
        public Fighter(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
        {

        }

        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifiedDealDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
    }
}