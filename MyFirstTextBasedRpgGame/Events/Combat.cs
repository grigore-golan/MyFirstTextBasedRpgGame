using MyFirstTextBasedRpgGame.Units;

namespace MyFirstTextBasedRpgGame.Events
{
    public class Combat
    {
        public BaseUnit Enemy { get; private set; }

        public bool HasEnded { get; private set; }

        public Combat(BaseUnit enemy)
        {
            Enemy = enemy;
            HasEnded = false;
        }

        public void StartBattle()
        {
            Player firstMove = Player.GetInstance();
            BaseUnit lastMove = Enemy;

            while(firstMove.IsAlive && lastMove.IsAlive && !HasEnded)
            {
                Console.WriteLine($"You: {firstMove.CurrentHP} HP\n{lastMove.Name}: {lastMove.CurrentHP} HP\n");

                firstMove.Act(lastMove, this);
                lastMove.Attack(firstMove);
            }
            HasEnded = true;
        }

        public void EndCombat()
        {
            HasEnded = true;

            Console.WriteLine("You succesfully escaped that battle.\n");
        }
    }
}
