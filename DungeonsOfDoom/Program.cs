﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Här startar vi spelet
            Game game = new Game();
            game.Play();
        }
    }
}
