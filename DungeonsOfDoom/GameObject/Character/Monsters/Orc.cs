using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DungeonsOfDoom
{
    class Orc : Monster
    {
        public Orc() : base(20, RandomUtils.RandomNumber(4, 10), 10, 15)
        {

        }

        public override bool IsWillingToFight(Character opponent)
        {
            if (opponent.Damage >= this.Damage * 2)
            {
                this.Health = 0;
                return false;
            }

            return true;
        }

        public override string Attack(Character opponent)
        {
            opponent.Health -= this.Damage;
            string damage = $"{DisplayName(this)} swings his axe in a frenzy dealing {this.Damage} damage to {DisplayName(opponent)}.";
            return damage;
        }

    }
}
