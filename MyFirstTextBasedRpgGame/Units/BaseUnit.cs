using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Units
{
    public abstract class BaseUnit
    {
        public string Name { get; protected set; }
        public int CurrentHP { get; protected set; }
        public int Damage { get; protected set; }

        public readonly int MaxHP;
        public bool IsAlive { get; protected set; }

        public IType Type { get; protected set; }

        public BaseUnit(int maxHP, int damage, IType type)
        {
            Name = "";
            MaxHP = maxHP;
            CurrentHP = maxHP;
            Damage = damage;
            IsAlive = true;
            Type = type;
        }

        public void ReceiveDamage(int damage)
        {
            if (CurrentHP > damage)
            {
                CurrentHP -= damage;
            }
            else
            {
                damage = CurrentHP;
                CurrentHP -= damage;
                IsAlive = false;
            }

            Console.WriteLine($"{this.Name} received {damage} damage.\n");
        }

        public void Attack(BaseUnit enemy)
        {
            enemy.ReceiveDamage(this.GetDamage());
            if (!enemy.IsAlive)
            {
                Console.WriteLine($"{enemy.Name} lost this battle and became one with the oblivion.\n");
            }
        }

        public abstract int GetDamage();
    }
}
