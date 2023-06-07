using MyFirstTextBasedRpgGame.Common;
using MyFirstTextBasedRpgGame.Events.Abstractions;
using MyFirstTextBasedRpgGame.Units;
using MyFirstTextBasedRpgGame.Units.Enemies;

namespace MyFirstTextBasedRpgGame.Events.Visitors
{
    public class EventVisitor : IVisitor
    {
        public void Visit(EnemyVisitable visitable)
        {
            BaseUnit unit;

            var random = Randomizer.GetRandomUpTo100();

            if (random < 30)
                unit = EnemyFactory.Create("doomed");
            else if (random >= 30 && random < 60)
                unit = EnemyFactory.Create("melee_bandit");
            else if (random >= 60 && random < 90)
                unit = EnemyFactory.Create("ranged_bandit");
            else
                unit = EnemyFactory.Create("special_doomed");

            Console.WriteLine($"There is an {unit.Name} in sight, prepare for battle or escape.\n");

            var combat = new Combat(unit);
            combat.StartBattle();
        }

        public void Visit(ResourceVisitable visitable)
        {
            Console.WriteLine("Hmm, maybe you can find some Healing Potions in there.\n");

            int quantity;
            var random = Randomizer.GetRandomUpTo100();

            if (random < 30)
                quantity = 0;
            else if (random >= 30 && random < 60)
                quantity = 1;
            else if (random >= 60 && random < 90)
                quantity = 2;
            else
                quantity = 5;

            Player.GetInstance().CollectHealingPotions(quantity);
        }
    }
}
