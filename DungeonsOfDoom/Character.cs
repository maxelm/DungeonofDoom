using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Character : GameObject
    {
        public int HealthPool { get; set; }
        public int Damage { get; set; }
        //public int Defense { get; set; }
        //public int Speed { get; set; }
        public List<Item> Backpack { get; set; }

        public Character(int healthPool, int damage, char displayChar) : base(displayChar)
        {
            HealthPool = healthPool;
            Damage = damage;
            Backpack = new List<Item>();
        }

        public void Attack() // Metod för att göra skada
        {

        }
        


    }
}
