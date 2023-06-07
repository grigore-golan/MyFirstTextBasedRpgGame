namespace MyFirstTextBasedRpgGame.Units.Enemies.EnemyType
{
    public class Ranged : IType
    {
        public int GetAccuracy()
        {
            return 70;
        }

        public int GetCriticalChance()
        {
            return 35;
        }

        public int GetCriticalDamageMultiplier()
        {
            return 250;
        }
    }
}
