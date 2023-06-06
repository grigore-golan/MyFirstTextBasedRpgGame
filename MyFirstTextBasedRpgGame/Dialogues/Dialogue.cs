using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues
{
    public class Dialogue
    {
        public ICollection<DialogueLine> Lines { get; private set; }

        public Dialogue()
        {
            Lines = new List<DialogueLine>();
        }

        public void Display()
        {
            var nextLine = Lines.First();
            while ( nextLine != null )
            {
                nextLine.Display();
                Console.ReadLine();
                nextLine = nextLine.NextLine;
            }
        }
    }

    public class DialogueBuilder
    {
        private Dialogue _dialogue = new();

        public DialogueBuilder AddLine(DialogueLine line)
        {
            if (_dialogue.Lines.Count > 0)
            {
                _dialogue.Lines.Last().NextLine = line;
                line.PreviousLine = _dialogue.Lines.Last();
            }
            _dialogue.Lines.Add(line);
            return this;
        }

        public Dialogue Build()
        {
            return _dialogue;
        }

        public void Reset()
        {
            _dialogue = new Dialogue();
        }
    }
}
