using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DoDLibrary.GameObjects.Characters.Monsters
{
    public class Orc : Monster
    {
        /// <summary>
        /// Constructor for creating an Orc.
        /// </summary>
        public Orc() : base(20, RandomUtils.RandomNumber(4, 10), 10, 15)
        {

        }
        /// <summary>
        /// Specific method for determining if Orc will fight opponent.
        /// </summary>
        /// <param name="opponent">The Orcs opponent.</param>
        /// <returns>Returns a true/false value</returns>
        public override bool IsWillingToFight(Character opponent)
        {
            if (opponent.Damage >= this.Damage * 2)
            {
                this.Health = 0;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Orc specific method for attacking opponent.
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns></returns>
        public override string Attack(Character opponent)
        {
            opponent.Health -= this.Damage;
            string damage = $"{TextUtils.DisplayName(this)} swings his axe in a frenzy dealing {this.Damage} damage to {TextUtils.DisplayName(opponent)}.";
            return damage;
        }

    }
}
