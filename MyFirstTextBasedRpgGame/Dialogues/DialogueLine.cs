namespace MyFirstTextBasedRpgGame.Dialogues
{
    public class DialogueLine
    {
        public string Text { get; set; }
        public string Teller { get; set; }

        public DialogueLine? NextLine { get; set; }
        public DialogueLine? PreviousLine { get; set; }

        public DialogueLine(string text, string teller, DialogueLine? nextLine = null, DialogueLine? previousLine = null)
        {
            this.Text = text;
            this.Teller = teller;
            this.NextLine = nextLine;
            this.PreviousLine = previousLine;
        }

        public void Display()
        {
            Console.WriteLine(Teller);

            if (!string.IsNullOrEmpty(Text))
                foreach (var character in Text)
                {
                    Console.Write(character);
                    Thread.Sleep(15);
                }

            Console.WriteLine();
        }
    }
}
