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
            Console.WriteLine("Oh, it seems to be a not agressive form of life. Maybe you should approach him.");
        }

        public void Visit(ScavengingVisitable visitable)
        {
            Console.WriteLine("You think you can found a lot of goods in there.");
        }
    }
}
