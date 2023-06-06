using MyFirstTextBasedRpgGame.Common.BaseEntities;
using MyFirstTextBasedRpgGame.Dialogues;

namespace MyFirstTextBasedRpgGame
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Player player = Player.GetInstance();

            var testLine = new DialogueLine(null, null, null, "Welcome, fellow adventurer. This is just text to see how fast will text be going...");

            testLine.Display();
        }
    }
}