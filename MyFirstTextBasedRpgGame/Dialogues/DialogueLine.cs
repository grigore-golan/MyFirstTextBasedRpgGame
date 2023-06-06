using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues
{
    public class DialogueLine
    {
        public string Text { get; set; }

        public DialogueLine? NextLine { get; set; }
        public DialogueLine? PreviousLine { get; set; }

        public DialogueLine(string text = "", DialogueLine? nextLine = null, DialogueLine? previousLine = null)
        {
            this.Text = text;
            this.NextLine = nextLine;
            this.PreviousLine = previousLine;
        }

        public void Display()
        {
            if (!string.IsNullOrEmpty(Text))
            foreach(var character in Text)
            {
                Console.Write(character);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
    }
}
