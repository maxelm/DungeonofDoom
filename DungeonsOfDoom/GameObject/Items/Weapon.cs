using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Weapon : Item
    {
        public int Damage { get; set; }
        // todo lägg till durability
        public Weapon(string name, int damage) : base(name)
        {
            Damage = damage;
        }

        //public override string PickUpItem(Character character)
        //{
        //    character.Backpack.Add(this);

        //    return null; //todo change!!!!
        //}

    }
}
