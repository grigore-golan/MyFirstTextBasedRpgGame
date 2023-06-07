using MyFirstTextBasedRpgGame.Events;
using MyFirstTextBasedRpgGame.Units;
using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame.Common.BaseEntities
{
    public sealed class Player : BaseUnit
    {
        private static Player _instance;
        private static object _instanceLock = new();

        public int HealingPotionsCount { get; private set; }
        public int Level { get; private set; }

        public const string Pronoun = "You";

        private Player() : base(20, 5, new Melee())
        {
            this.Name = "Adventurer";
            this.Level = 1;
            this.HealingPotionsCount = 5;
        }

        public static Player GetInstance()
        {
            if (_instance == null)
                lock (_instanceLock)
                    if (_instance == null)
                        _instance = new Player();

            return _instance;
        }

        public void Act(BaseUnit enemy, Combat combat)
        {
            Console.Write("What will you do?\n" +
                              "1. Attack\n" +
                              "2. Heal\n" +
                              "3. Try to escape.\n\n" +
                              ">> ");

            string? option;
            bool exit = true;

            while (exit)
            {
                option = Console.ReadLine();

                if (string.IsNullOrEmpty(option) || option.Length > 1 || !char.IsDigit(option[0]))
                {
                    Console.WriteLine("There is no such an option! (Put a number that coresponds with the action you would like to do)\n");
                }
                else
                {
                    switch (option[0])
                    {
                        case '1':
                            Attack(enemy);
                            exit = false;
                            break;
                        case '2':
                            if (HealingPotionsCount > 0)
                            {
                                Heal();
                                exit = false;
                            }
                            else
                            {
                                Console.WriteLine("You don't have any Healing Potions left.\n");
                            }
                            break;
                        case '3':
                            if (Randomizer.GetRandomUpTo100() > 75)
                            {
                                combat.EndCombat();
                            }
                            exit = false;
                            break;
                        default:
                            break;
                    }
                }
            } 
        }

        public void Heal()
        {
            var healAmount = 15;
            if (CurrentHP + healAmount > MaxHP)
                healAmount = MaxHP - CurrentHP;

            CurrentHP += healAmount;
            HealingPotionsCount--;

            Console.WriteLine($"You gained {healAmount} HP from Healing Potion.\n" +
                              $"{this.HealingPotionsCount} Healing Potions left.\n");
        }

        public override int GetDamage()
        {
            return this.Damage;
        }
    }
}
