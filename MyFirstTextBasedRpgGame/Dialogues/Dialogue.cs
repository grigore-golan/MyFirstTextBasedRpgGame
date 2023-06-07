using MyFirstTextBasedRpgGame.Dialogues.DisplayStrategies;
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
        public Strategy DisplayStrategy { get; private set; }

        public Dialogue(Strategy displayStrategy)
        {
            Lines = new List<DialogueLine>();
            DisplayStrategy = displayStrategy;
        }

        public void Display()
        {
            var nextLine = Lines.First();
            while ( nextLine != null )
            {
                DisplayStrategy.Display(nextLine);
                Console.ReadLine();
                nextLine = nextLine.NextLine;
            }
        }

        public void ChangeDisplayStrategy(Strategy strategy)
        {
            DisplayStrategy = strategy;
        }
    }

    public class DialogueBuilder
    {
        private Dialogue _dialogue = new(new NormalStrategy());

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
            _dialogue = new Dialogue(new NormalStrategy());
        }
    }
}
