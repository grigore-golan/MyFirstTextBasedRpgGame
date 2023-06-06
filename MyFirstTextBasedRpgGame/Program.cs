using MyFirstTextBasedRpgGame.Dialogues.Interactive;

namespace MyFirstTextBasedRpgGame
{
    public class Program
    {
        public static void Main() 
        {
            Player player = Player.GetInstance();

            InitialDialogue dialogue = new();
            dialogue.Dialogue.Display();
        }
    }
}