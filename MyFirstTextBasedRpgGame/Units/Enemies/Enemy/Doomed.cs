using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Units.Enemies.Enemy
{
    public class Doomed : BaseUnit
    {
        public Doomed(int maxHP, int damage, IType type) : base(maxHP, damage, type)
        {
            this.Name = type.GetType().Name + " " + this.GetType().Name;
        }
    }
}
