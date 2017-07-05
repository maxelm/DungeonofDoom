using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item : GameObject, ICarryable
    {
        public string Name { get; }

        public Item(string name) : base('I')
        {
            Name = name;
        }

        public virtual string GetPickedUp(Character character)
        {
            character.Backpack.Add(this);

            return $"{this.Name} was added to your backpack.";
        }
    }
}
