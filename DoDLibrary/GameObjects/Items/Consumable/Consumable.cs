using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDLibrary.GameObjects.Items.Consumables
{
    public abstract class Consumable : Item
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public Consumable(string name, int health, int damage, int defense, int speed) : base(name)
        {
            Health = health;
            Damage = damage;
            Defense = defense;
            Speed = speed;
        }

        //public override string PickUpItem(Character character)
        //{
        //    int oldHealth = character.HealthPool;
        //    character.HealthPool += this.Health;

        //    return $"You consumed a {this.Name} and gained {character.HealthPool - oldHealth} HP";
        //}
    }
}
