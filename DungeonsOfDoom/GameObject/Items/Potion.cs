using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public int Health { get; set; }

        public Potion(string name, int health) : base(name)
        {
            Health = health;
        }
    }
}
