using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDLibrary.GameObjects
{
    public abstract class GameObject
    {
        public char DisplayChar { get;}

        public GameObject(char displayChar)
        {
            DisplayChar = displayChar;
        }
        /// <summary>
        /// Method for displaying the name of the objects type.
        /// </summary>
        /// <returns></returns>
        //public string DisplayName()
        //{
        //    return this.GetType().Name;
        //}

    }
}
