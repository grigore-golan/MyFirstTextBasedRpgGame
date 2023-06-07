namespace MyFirstTextBasedRpgGame.Units.Enemies.EnemyType
{
    public interface IType
    {
        public int GetAccuracy();
        public int GetCriticalChance();
        public int GetCriticalDamageMultiplier();
    }
}
