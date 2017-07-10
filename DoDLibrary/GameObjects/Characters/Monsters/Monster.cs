using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DoDLibrary.GameObjects.Characters.Monsters
{
    /// <summary>
    /// Represents a monster in the dungeon.
    /// </summary>
    public abstract class Monster : Character, ICarryable
    {
        /// <summary>
        /// Constructor for creating a new monster.
        /// </summary>
        /// <param name="healthPool">Monsters health pool</param>
        /// <param name="damage">Monsters damage value</param>
        /// <param name="defense">Monsters defense value</param>
        /// <param name="speed">Monsters speed value</param>
        public Monster(int healthPool, int damage, int defense, int speed) : base(healthPool, damage, defense, speed, 'M')
        {
            
        }

        public virtual string GetPickedUp(Character character)
        {
                character.Backpack.Add(this);
                return $"{TextUtils.DisplayName(this)}'s carcass was added to your backpack.";

        }


    }
}
