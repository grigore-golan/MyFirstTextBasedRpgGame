using MyFirstTextBasedRpgGame.Units.Enemies.Enemy;
using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;
using System;

namespace MyFirstTextBasedRpgGame.Units.Enemies
{
    public class EnemyFactory
    {
        private static readonly Dictionary<string, Func<BaseUnit>> _creators = new();

        static EnemyFactory()
        {
            _creators["doomed"] = () => new Doomed(20, 4, new Melee());
            _creators["special_doomed"] = () => new Doomed(25, 4, new Special());
            _creators["melee_bandit"] = () => new Bandit(16, 3, new Melee());
            _creators["ranged_bandit"] = () => new Bandit(12, 5, new Ranged());
        }

        public static BaseUnit Create(string type)
        {
            Func<BaseUnit> creator;

            _creators.TryGetValue(type, out creator);

            if (creator == null)
                throw new Exception("There is no such a unit!");

            BaseUnit potion = creator();
            return potion;
        }
    }
}
