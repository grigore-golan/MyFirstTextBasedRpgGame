using MyFirstTextBasedRpgGame.Events.Abstractions;

namespace MyFirstTextBasedRpgGame.Events.Visitors
{
    public class EventVisitor : IVisitor
    {
        public void Visit(EnemyVisitable visitable)
        {
            Console.WriteLine("There is an enemy in sight, prepare for battle or escape.");
        }

        public void Visit(NpcVisitable visitable)
        {
            Console.WriteLine("Oh, it seems to be a non-agressive form of life. Maybe you should approach him.");
        }

        public void Visit(ResourceVisitable visitable)
        {
            Console.WriteLine("Hmm, maybe you can find a lot of goods in there.");
        }
    }
}
