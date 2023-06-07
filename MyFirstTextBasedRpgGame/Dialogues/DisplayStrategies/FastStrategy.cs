namespace MyFirstTextBasedRpgGame.Dialogues.DisplayStrategies
{
    public class FastStrategy : Strategy
    {
        public override void Display(DialogueLine line)
        {
            if (!string.IsNullOrEmpty(line.Text))
                Console.WriteLine($"[{line.Teller}] {line.Text}\n");
        }
    }
}
