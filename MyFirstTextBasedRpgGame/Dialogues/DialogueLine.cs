using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues
{
    public  class DialogueLine
    {
        public string Text { get; set; }

        public DialogueLine? NextLine { get; set; }
        public DialogueLine? PreviousLine { get; set; }
        public Dialogue? PartOf { get; set; }


        public DialogueLine(Dialogue? partOf, DialogueLine? nextLine, DialogueLine? previousLine, string text = "")
        {
            this.Text = text;
            this.PartOf = partOf;
            this.NextLine = nextLine;
            this.PreviousLine = previousLine;
        }

        public void Display()
        {
            foreach(var character in Text)
            {
                Console.Write(character);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
    }
}
