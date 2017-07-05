using DoDLibrary.GameObjects.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDLibrary.GameObjects
{
    public interface ICarryable
    {
        /// <summary>
        /// Specifies what will happen when a gameobject is picked up.
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        string GetPickedUp(Character character);
    }
}
