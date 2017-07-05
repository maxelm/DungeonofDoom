using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DoDLibrary.GameObjects.Characters
{
    public abstract class Character : GameObject
    {
        public virtual int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public List<ICarryable> Backpack { get; set; }

        /// <summary>
        /// Constructor for creating a new character.
        /// </summary>
        /// <param name="healthPool">Characters health pool.</param>
        /// <param name="damage">Characters damage value.</param>
        /// <param name="defense">Characters defense value.</param>
        /// <param name="speed">Characters speed value.</param>
        /// <param name="displayChar">Characters char to be displayed in world.</param>
        public Character(int healthPool, int damage, int defense, int speed, char displayChar) : base(displayChar)
        {
            this.Health = healthPool;
            Damage = damage;
            Defense = defense;
            Speed = speed;
            Backpack = new List<ICarryable>();
        }
        /// <summary>
        /// Default method for attacking your opponent.
        /// </summary>
        /// <param name="opponent">The opponent character to attack.</param>
        /// <returns></returns>
        public virtual string Attack(Character opponent)
        {
            opponent.Health -= this.Damage;
            string damage = $"{TextUtils.DisplayName(this)} attacked {TextUtils.DisplayName(opponent)} for {this.Damage}.";
            return damage;

        }

        public virtual bool IsWillingToFight(Character opponent)
        {
            return true;
        }





    }
}
