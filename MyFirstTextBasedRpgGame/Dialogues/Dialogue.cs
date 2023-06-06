using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTextBasedRpgGame.Dialogues
{
    public abstract class Dialogue
    {
        protected ICollection<DialogueLine> Lines { get; set; }
        public Dialogue()
        {
            Lines = new List<DialogueLine>();
        }
    }
}
