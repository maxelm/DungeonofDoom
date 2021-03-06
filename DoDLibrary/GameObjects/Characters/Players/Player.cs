﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDLibrary.GameObjects.Characters.Players
{
    public class Player : Character
    {
        private const int MaxHp = 50;
        private int healthPool;
        public override int Health
        {
            get
            { return healthPool; }
            set
            {
                healthPool = value;
                if (healthPool > MaxHp)
                    healthPool = MaxHp;
            }
        }
        public int X { get; set; }
        public int Y { get; set; }
        /// <summary>
        /// Constructor for creating a new player.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y) : base(100, 10, 10, 20, 'P')
        {
            X = x;
            Y = y;
            healthPool = MaxHp;
        }

    }
}
