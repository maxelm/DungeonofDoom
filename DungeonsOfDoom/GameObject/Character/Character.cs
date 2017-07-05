using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Character : GameObject
    {
        public virtual int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public List<ICarryable> Backpack { get; set; }

        public Character(int healthPool, int damage, int defense, int speed, char displayChar) : base(displayChar)
        {
            this.Health = healthPool;
            Damage = damage;
            Defense = defense;
            Speed = speed;
            Backpack = new List<ICarryable>();
        }

        public virtual string Attack(Character opponent) // Metod för att göra skada
        {
            opponent.Health -= this.Damage;
            string damage = $"{DisplayName(this)} attacked {DisplayName(opponent)} for {this.Damage}.";
            return damage;

        }

        public static string DisplayName(Character character)
        {
            string[] temp = character.ToString().Split('.');
            return temp[temp.Length - 1];
        }


        public virtual bool IsWillingToFight(Character opponent)
        {
            return true;
        }





    }
}
