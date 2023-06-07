using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Units
{
    public abstract class BaseUnit
    {
        public string Name { get; protected set; }
        public int MaxHP { get; protected set; }
        public int CurrentHP { get; protected set; }
        public int Damage { get; protected set; }

        //public int RewardXP { get; protected set; }
        public bool IsAlive { get; protected set; }

        public IType Type { get; protected set; }

        public BaseUnit(string name, int maxHP, int damage/*, int rewardXP*/, IType type)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            Damage = damage;
            //RewardXP = rewardXP;
            IsAlive = true;
            Type = type;
        }

        public void ReceiveDamage(int damage)
        {
            if (CurrentHP > damage)
                CurrentHP -= damage;
            else
            {
                CurrentHP = 0;
                IsAlive = false;
            }
        }

        public void DoDamage(BaseUnit enemy)
        {
            enemy.ReceiveDamage(this.GetDamage());
        }

        public abstract int GetDamage();
    }
}
