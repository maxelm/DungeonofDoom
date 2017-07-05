using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class GameObject
    {
        public char DisplayChar { get;}

        public GameObject(char displayChar)
        {
            DisplayChar = displayChar;
        }

        public string DisplayName()
        {
            return this.GetType().Name;
        }

    }
}
