namespace MyFirstTextBasedRpgGame.Units.Enemies.EnemyType
{
    public class Melee : IType
    {
        public int GetAccuracy()
        {
            return 85;
        }

        public int GetCriticalChance()
        {
            return 25;
        }

        public int GetCriticalDamageMultiplier()
        {
            return 175;
        }
    }
}
