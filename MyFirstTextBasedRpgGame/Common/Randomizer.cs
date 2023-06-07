using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Common
{
    public static class Randomizer
    {
        public static int GetRandomUpTo100()
        {
            Random rnd = new();
            int num = rnd.Next(100);

            return num;
        }
    }
}
