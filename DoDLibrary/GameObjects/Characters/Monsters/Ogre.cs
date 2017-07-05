using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DoDLibrary.GameObjects.Characters.Monsters
{
    public class Ogre : Monster
    {
        /// <summary>
        /// Constructor for creating an Ogre.
        /// </summary>
        public Ogre() : base(30, 10, 5, 5)
        {

        }

        /// <summary>
        /// Ogre specific method for attacking the opponent.
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns></returns>
        public override string Attack(Character opponent)
        {
            opponent.Health -= this.Damage;
            string damage = $"{TextUtils.DisplayName(this)} raises his heavy club and smashes it down with terrible force on {TextUtils.DisplayName(opponent)} dealing {this.Damage} damage.";
            return damage;
        }
    }
}
