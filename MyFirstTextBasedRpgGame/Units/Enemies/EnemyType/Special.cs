using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Units.Enemies.EnemyType
{
    public class Special : IType
    {
        public int GetAccuracy()
        {
            return 90;
        }

        public int GetCriticalChance()
        {
            return 50;
        }

        public int GetCriticalDamageMultiplier()
        {
            return 300;
        }
    }
}
