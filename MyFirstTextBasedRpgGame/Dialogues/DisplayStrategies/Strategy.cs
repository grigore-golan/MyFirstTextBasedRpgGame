using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues.DisplayStrategies
{
    public abstract class Strategy
    {
        public abstract void Display(DialogueLine line);
    }
}
