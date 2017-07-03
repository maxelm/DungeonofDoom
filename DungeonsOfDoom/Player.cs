using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int x, int y) : base(100, 10, 'P')
        {
            X = x;
            Y = y;
        }

    }
}
