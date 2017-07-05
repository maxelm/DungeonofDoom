using DoDLibrary.GameObjects.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary;

namespace DoDLibrary.GameObjects.Items.Consumables
{

    public class StrengthPotion : Consumable
    {
        public StrengthPotion() : base("Strength Potion", 0, RandomUtils.RandomNumber(1,3), 0, 0)
        {

        }

        public override string GetPickedUp(Character character)
        {
            int oldStrength = character.Damage;
            character.Damage += this.Damage;

            return $"You consumed a {this.Name} and gained {character.Damage - oldStrength} damage";
        }
    }
}
