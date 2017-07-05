using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Ogre : Monster
    {
        public Ogre() : base(30, 10, 5, 5)
        {

        }

        public override string Attack(Character opponent)
        {
            opponent.Health -= this.Damage;
            string damage = $"{DisplayName(this)} raises his heavy club and smashes it down with terrible force on {DisplayName(opponent)} dealing {this.Damage} damage.";
            return damage;
        }
    }
}
