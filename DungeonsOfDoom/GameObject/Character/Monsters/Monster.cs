using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character
    {
        public Monster(int healthPool, int damage, int defense, int speed) : base(healthPool, damage, defense, speed, 'M')
        {
            
        }

    }
}
