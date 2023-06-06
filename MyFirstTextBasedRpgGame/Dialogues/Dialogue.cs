using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues
{
    public class Dialogue
    {
        protected ICollection<DialogueLine> Lines { get; set; }
        public Dialogue()
        {
            Lines = new List<DialogueLine>();
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
}
