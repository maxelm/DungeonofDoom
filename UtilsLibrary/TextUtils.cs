﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UtilsLibrary
{
    public static class TextUtils
    {
        public static void Animate(string value)
        {
            foreach (char c in value)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine();
        }

        public static string DisplayName(object gameObject)
        {
            return gameObject.GetType().Name;
        }
    }
}
