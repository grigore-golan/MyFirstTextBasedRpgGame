using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Units.Enemies.Enemy
{
    public class Doomed : BaseUnit
    {
        public Doomed(int maxHP, int damage, IType type) : base(maxHP, damage, type)
        {
            this.Name = type.GetType().Name + " " + this.GetType().Name;
        }

        public override int GetDamage()
        {
            if (Randomizer.GetRandomUpTo100() < Type.GetAccuracy())
            {
                if (Randomizer.GetRandomUpTo100() < Type.GetCriticalChance())
                {
                    return Damage * Type.GetCriticalDamageMultiplier() / 100;
                }
                else
                {
                    return Damage;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
