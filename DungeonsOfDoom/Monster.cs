using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Monster : Character
    {
        public Monster(int healthPool, int damage) : base(healthPool, damage, 'M')
        {
            
        }

    }
}
