using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item : GameObject
    {
        public string Name { get;}

        public Item(string name) : base('I')
        {
            Name = name;
        }

    }
}
