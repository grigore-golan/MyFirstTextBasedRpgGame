using MyFirstTextBasedRpgGame.Units;
using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Common.BaseEntities
{
    public sealed class Player : BaseUnit
    {
        private static Player _instance;
        private static object _instanceLock = new();

        //public int CurrentXP { get; set; }
        //public int NeededXPForLevelUp { get; private set; }
        public int Level { get; private set; }

        public const string Pronoun = "You";

        private Player() : base("Adventurer", 20, 5/*, 0*/, new Melee())
        {
            this.Level = 1;
        }

        public static Player GetInstance()
        {
            if (_instance == null)
                lock (_instanceLock)
                    if (_instance == null)
                        _instance = new Player();

            return _instance;
        }

        //private void LevelUp()
        //{
        //    this.Level++;
        //    ReCalculateMaxHP();
        //    ReCalculateDamage();
        //}

        //private void ReCalculateMaxHP()
        //{
        //    this.MaxHP = 15 + Level * 5;
        //}

        //private void ReCalculateDamage()
        //{
        //    this.Damage = 3 + Level * 2;
        //}

        public override int GetDamage()
        {
            return this.Damage;
        }
    }
}
