using MyFirstTextBasedRpgGame.Dialogues.Interactive;
using MyFirstTextBasedRpgGame.Events;
using MyFirstTextBasedRpgGame.Units.Enemies.Enemy;
using MyFirstTextBasedRpgGame.Units.Enemies.EnemyType;

namespace MyFirstTextBasedRpgGame
{
    public class Program
    {
        public static void Main() 
        {
            SoundPlayer soundPlayer = new()
            {
                SoundLocation = @"D:\Downloads\Chrome\gameBackground.wav"
            };
            soundPlayer.Play();

            Player player = Player.GetInstance();

            InitialDialogue dialogue = new();
            dialogue.Dialogue.Display();

            var firstEnemy = new Doomed(15, 3, new Melee());

            var testCombat = new Combat(firstEnemy);
            testCombat.StartBattle();

            Console.WriteLine("What happened next to our brave Adventurer we will find out soon...\n" +
                              "But now, this is the end... Is this the end?");

            Console.ReadLine();
        }
    }
}