using MyFirstTextBasedRpgGame.Dialogues.Interactive;

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


        }
    }
}