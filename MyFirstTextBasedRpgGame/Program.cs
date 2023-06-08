using MyFirstTextBasedRpgGame.Dialogues.DisplayStrategies;
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

            if (NeedsToBeFast())
                dialogue.Dialogue.ChangeDisplayStrategy(new FastStrategy());

            Console.Clear();

            dialogue.Dialogue.Display();

            while (player.IsAlive)
            {
                var gameEvent = EventGenerator.Generate();
                gameEvent.Accept(visitor);
                Console.ReadLine();
            }

            Console.WriteLine("As for now, the Adventurer is outside of our understanding.\n" +
                              "But now, this is the end...\n" +
                              "Or it is not?...\n\n\n\n" +
                              $"[Final Score: {player.Score}]");

            Console.ReadLine();
        }

        public static bool NeedsToBeFast()
        {
            Console.WriteLine("You want this dialogue to be fast? (y/n)\n");

            string input;

            input = Console.ReadLine();

            if (input[0] == 'y')
                return true;
            else
                return false;
        }
    }
}