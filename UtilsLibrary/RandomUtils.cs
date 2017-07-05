using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary
{
    public static class RandomUtils
    {
        static Random random = new Random();

        public static bool ChanceToCreate (int percentage)
        {
            if (percentage > 100 || percentage < 0)
                throw new Exception("Percentage must be between 0-100");

            return random.Next(0, 100) < percentage;
            
        }

        public static int RandomNumber (int lowerValue, int maxValue)
        {
            return random.Next(lowerValue, maxValue + 1);
        }

    }
}
