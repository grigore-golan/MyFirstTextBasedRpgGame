using MyFirstTextBasedRpgGame.Dialogues.Interactive;
using MyFirstTextBasedRpgGame.Events;
using MyFirstTextBasedRpgGame.Events.Visitors;

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
            EventVisitor visitor = new();

            InitialDialogue dialogue = new();
            dialogue.Dialogue.Display();

            while (player.IsAlive)
            {
                var gameEvent = EventGenerator.Generate();
                gameEvent.Accept(visitor);
                Console.ReadLine();
            }

            Console.WriteLine("What happened next to our brave Adventurer we will find out soon...\n" +
                              "But now, this is the end...\n" +
                              "Or it is not?...\n\n\n" +
                              $"[Final Score: {player.Score}]");

            Console.ReadLine();
        }
    }
}