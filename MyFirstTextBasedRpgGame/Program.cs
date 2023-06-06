using MyFirstTextBasedRpgGame.Common.BaseEntities;
using MyFirstTextBasedRpgGame.Dialogues;

namespace MyFirstTextBasedRpgGame
{
    public class Program
    {
        public static void Main() 
        {
            Player player = Player.GetInstance();

            var testLine = new DialogueLine("Welcome, fellow adventurer. This is just text to see how fast will text be going...", null, null);

            testLine.Display();
        }
    }
}