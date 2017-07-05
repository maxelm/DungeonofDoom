using DungeonsOfDoom.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class HealthPotion : Consumable
    {

        public HealthPotion() : base("Health Potion", RandomUtils.RandomNumber(5, 15), 0, 0, 0)
        {

        }

        public override string GetPickedUp(Character character)
        {

            int oldHealth = character.Health;
            character.Health += this.Health;

            return $"You consumed a {this.Name} and gained {character.Health - oldHealth} HP";
        }
    }
}
