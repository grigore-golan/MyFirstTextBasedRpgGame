using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstTextBasedRpgGame.Dialogues.DisplayStrategies
{
    public class NormalStrategy : Strategy
    {
        public override void Display(DialogueLine line)
        {
            Console.WriteLine(line.Teller);

            if (!string.IsNullOrEmpty(line.Text))
                foreach (var character in line.Text)
                {
                    Console.Write(character);
                    Thread.Sleep(15);
                }

            Console.WriteLine();
        }
    }
}
