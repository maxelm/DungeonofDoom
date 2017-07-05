using DoDLibrary.GameObjects.Characters.Monsters;
using DoDLibrary.GameObjects.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDLibrary.GameObjects.Rooms
{
    public class Room : GameObject
    {
        public Monster Monster { get; set; }
        public Item Item { get; set; }

        public Room() : base('.')
        {

        }

    }

}
