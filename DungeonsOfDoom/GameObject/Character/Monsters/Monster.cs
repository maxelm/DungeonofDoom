using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character, ICarryable
    {
        public Monster(int healthPool, int damage, int defense, int speed) : base(healthPool, damage, defense, speed, 'M')
        {
            
        }

        public virtual string GetPickedUp(Character character)
        {
                character.Backpack.Add(this);
                return $"{Character.DisplayName(this)}'s carcass was added to your backpack.";

        }


    }
}
